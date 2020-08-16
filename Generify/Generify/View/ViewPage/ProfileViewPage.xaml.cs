using Generify.View.ViewPage.Base;
using Xamarin.Forms.Xaml;

namespace Generify.View.ViewPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileViewPage : BaseViewPage
	{
		public ProfileViewPage()
		{
			InitializeComponent();
		}
	}
}