using System;
using System.Collections.Generic;
using System.Text;

namespace Generify.Contracts.Page
{
	public interface IPage
	{
		void OnCreate(object navigationData);

		void OnDestroy();
	}
}
