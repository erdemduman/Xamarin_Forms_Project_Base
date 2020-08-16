using System;
using System.Collections.Generic;
using System.Text;

namespace Generify.Contracts
{
	public interface IViewModel
	{
		void OnCreate(object NavigationData);

		void OnDestroy();
	}
}
