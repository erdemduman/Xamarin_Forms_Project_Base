using Generify.Contracts;
using Generify.Page.Base;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Generify.Common.Navigation
{
	public class NavigationManager
	{
		public async Task GoToPageAsync(IPage page)
		{
			var navigation = GetNavigation();
			var pageToCreate = page as BasePage;
			var currentPage = GetCurrentPage(navigation, PageType.BasePage);
			

		}

		public async Task GoToTabbedPageAsync(IPage page)
		{

		}

		private INavigation GetNavigation()
		{
			var rootPage = Application.Current.MainPage as MasterDetailPage;
			if (rootPage == null)
				throw new NotSupportedException();

			var navigationPage = rootPage.Detail as NavigationPage;
			if (navigationPage == null)
				throw new NotSupportedException();

			return navigationPage.Navigation;
		}

		private IPage GetCurrentPage(INavigation navigation, PageType pageType)
		{
			if (pageType == PageType.BasePage)
				return navigation.NavigationStack[navigation.NavigationStack.Count - 1] as BasePage;
			else if (pageType == PageType.TabbedPage)
				return navigation.NavigationStack[navigation.NavigationStack.Count - 1] as BaseTabbedPage;
			else
				throw new NotSupportedException();
		}

		private enum PageType
		{
			BasePage,
			TabbedPage
		}
	}
}
