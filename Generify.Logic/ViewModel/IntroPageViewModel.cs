using Generify.Contracts.Page;
using Generify.Logic.ViewModel.Base;
using System.Windows.Input;
using Xamarin.Forms;

namespace Generify.Logic.ViewModel
{
	public class IntroPageViewModel : BaseViewModel
	{
		public override void OnCreate(object navigationData)
		{
			base.OnCreate(navigationData);
			SetCommand("GoToMainPage", CmdGoToMainPage);
		}

		#region Commands
		public void CmdGoToMainPage()
		{
			Navigation.GoToPageAsync<IMainPage>();
		}
		#endregion

		public class Parameter : BaseParameter
		{
		}
	}
}
