using Generify.Contracts;
using Generify.Contracts.Page;
using Generify.Logic.ViewModel;
using Generify.Page.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Generify.Logic.ViewModel.LoginPageViewModel;

namespace Generify.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : BasePage, ILoginPage
	{
		public LoginPage()
		{
			InitializeComponent();
			ViewModel = new LoginPageViewModel();
			InitBindingContext();
		}

		public void CreateWebView(AuthenticateParameter parameter)
		{
			var url = @"https://accounts.spotify.com/authorize?client_id=" +
				parameter.ClientId +
				"&response_type=" +
				parameter.ResponseType +
				"&redirect_uri=" +
				parameter.RedirectUri +
				"&scope=" +
				parameter.Scope +
				"&show_dialog=" +
				parameter.ShowDialog;

			var webView = new WebView
			{
				Source = url,
				HeightRequest = 1
			};

			Content = webView;
			webView.Navigated += OnWebViewNavigated;
		}

		private void OnWebViewNavigated(object sender, WebNavigatedEventArgs args)
		{

		}

		protected override IViewModel ViewModel { get; set; }
	}
}