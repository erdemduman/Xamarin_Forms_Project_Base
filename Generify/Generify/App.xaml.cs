using Generify.Logic;
using Xamarin.Forms;

namespace Generify
{
	public partial class App : Application
	{
		private readonly MyApp _app;

		public App()
		{
			InitializeComponent();
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
