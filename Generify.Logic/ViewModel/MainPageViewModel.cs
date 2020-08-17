using Generify.Logic.ViewModel.Base;

namespace Generify.Logic.ViewModel
{
	public class MainPageViewModel : BaseViewModel
	{

		public override void OnCreate(object navigationData)
		{
			base.OnCreate(navigationData);
			MyText = "Hello Xamarin.Forms!";
		}

		#region Properties
		public string MyText
		{
			get { return Get<string>(); }
			set { Set(value); }
		}
		#endregion

		public class Parameter : BaseParameter
		{

		}
	}
}
