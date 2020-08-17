using Generify.Contracts;
using Generify.Contracts.Page;
using Generify.Page.Base;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Generify
{
	public class NavigationManager : INavigationManager
	{
		public void SetMainPage<T>(object navigationData) where T : class, IPage
		{
			var page = GetPage<T>();
			Application.Current.MainPage = new NavigationPage(page);
			page.OnCreate(navigationData);
		}

		public async Task GoToPageAsync<T>(object navigationData) where T : class, IPage
		{
			var navigation = GetNavigation();
			var nextPage = DependencyManager.Resolve<T>() as BasePage;
			var currentPage = GetCurrentPage(navigation);
			currentPage.OnDestroy();
			await navigation.PushAsync(nextPage);
			nextPage.OnCreate(navigationData);
		}

		private INavigation GetNavigation()
		{
			var mainPage = Application.Current.MainPage;
			return mainPage.Navigation;
		}

		private BasePage GetCurrentPage(INavigation navigation)
		{
			return navigation.NavigationStack[navigation.NavigationStack.Count - 1] as BasePage;
		}

		private BasePage GetPage<T>() where T : class, IPage
		{
			return DependencyManager.Resolve<T>() as BasePage;
		}
	}
}
