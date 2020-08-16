using Generify.Contracts;
using Generify.Contracts.Page;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Generify.Logic
{
	public class MyApp
	{
		private readonly INavigationManager _navigation;

		private MyApp()
		{
			_navigation = DependencyManager.Resolve<INavigationManager>();
		}

		public void OnCreate()
		{
			_navigation.SetMainPage<ISplashPage>();
		}

		public void OnStart()
		{

		}

		public void OnResume()
		{

		}

		public void OnSleep()
		{

		}

		private static MyApp App { get; set; }

		#region Factory
		public static MyApp Factory()
		{
			if (App == null)
				App = new MyApp();

			return App;
		}
		#endregion
	}
}
