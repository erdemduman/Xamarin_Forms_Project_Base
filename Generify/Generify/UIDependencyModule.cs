using Autofac;
using Generify.Contracts;
using Generify.Contracts.Page;
using Generify.Page;

namespace Generify
{
	public class UIDependencyModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			LoadOthers(builder);
			LoadPages(builder);
			base.Load(builder);
		}

		private void LoadOthers(ContainerBuilder builder)
		{
			builder.RegisterType<NavigationManager>().As<INavigationManager>().SingleInstance();
		}

		private void LoadPages(ContainerBuilder builder)
		{
			builder.RegisterType<BottomNavigationPage>().As<IBottomNavigationPage>();
			builder.RegisterType<LoginPage>().As<ILoginPage>();
			builder.RegisterType<SplashPage>().As<ISplashPage>();
		}
	}
}
