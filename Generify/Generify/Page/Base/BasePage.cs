using Generify.Contracts;
using Generify.Contracts.Page;
using Xamarin.Forms;

namespace Generify.Page.Base
{
	public abstract class BasePage : ContentPage, IPage
	{
		public void InitBindingContext()
		{
			if (ViewModel != null)
			{
				BindingContext = ViewModel;
			}
		}

		#region LifeCycle
		public void OnCreate(object navigationData)
		{
			ViewModel.OnCreate(navigationData);
		}

		public void OnDestroy()
		{
			ViewModel.OnDestroy();
		}
		#endregion

		protected abstract IViewModel ViewModel { get; set; }
	}
}
