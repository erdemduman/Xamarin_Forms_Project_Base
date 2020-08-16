using Generify.Contracts.Page;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Generify.Contracts
{
	public interface INavigationManager
	{
		void SetMainPage<T>(object navigationData = null) where T : class, IPage;

		Task GoToPageAsync<T>(object navigationData = null) where T : class, IPage;
	}
}
