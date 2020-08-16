using Generify.Logic.Constants;
using Generify.Logic.ViewModel.Base;
using Xamarin.Forms;

namespace Generify.Logic.ViewModel
{
	public class SplashPageViewModel : BaseViewModel
	{
		public SplashPageViewModel()
		{
			
		}

		public override void OnCreate(object navigationData)
		{
			NavigateToLoginPage();
		}

		private async void NavigateToLoginPage()
		{
			if ((bool)Application.Current.Properties[ResourceConstant.IsAuth] == false)
			{
				
			}
		}

		public class Parameter : BaseParameter
		{
		}
	}
}
