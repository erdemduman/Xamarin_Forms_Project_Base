using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Generify.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TitleView : ContentView
	{
		public TitleView()
		{
			InitializeComponent();
		}

		public BindableProperty HideBackButtonProperty = BindableProperty.Create
		(
			propertyName: nameof(HideBackButton),
			returnType: typeof(bool),
			declaringType: typeof(TitleView), 
			defaultValue: false,
			propertyChanged: null
		);

		public bool HideBackButton
		{
			get { return (bool)GetValue(HideBackButtonProperty); }
			set { SetValue(HideBackButtonProperty, value); }
		}
	}
}