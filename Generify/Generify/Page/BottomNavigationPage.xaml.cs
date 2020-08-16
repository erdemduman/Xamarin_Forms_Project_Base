using Generify.Contracts;
using Generify.Contracts.Page;
using Generify.Logic.ViewModel.BottomNavigation;
using Generify.Page.Base;
using Xamarin.Forms.Xaml;


namespace Generify.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BottomNavigationPage : BasePage, IBottomNavigationPage
	{
		public BottomNavigationPage()
		{
			InitializeComponent();
			ViewModel = new BottomNavigationPageViewModel();
			InitBindingContext();
		}

		protected override IViewModel ViewModel { get; set; }
	}
}