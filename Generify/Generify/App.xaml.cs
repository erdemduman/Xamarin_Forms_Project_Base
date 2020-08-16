using Generify.Logic;
using Generify.Logic.Constants;
using Generify.Page;
using Generify.Page.Base;
using Xamarin.Forms;

namespace Generify
{
	public partial class App : Application
	{
		private readonly MyApp _app;

		public App()
		{
			InitializeComponent();
			if (!Current.Properties.ContainsKey(ResourceConstant.FirstRun))
			{
				Current.Properties[ResourceConstant.FirstRun] = true;
				Current.Properties[ResourceConstant.IsAuth] = false;
			}
			else
				Current.Properties[ResourceConstant.FirstRun] = false;

			_app = MyApp.Factory();
			_app.OnCreate();
		}

		protected override void OnStart()
		{
			_app.OnStart();
		}

		protected override void OnSleep()
		{
			_app.OnSleep();
		}

		protected override void OnResume()
		{
			_app.OnResume();
		}
	}
}
