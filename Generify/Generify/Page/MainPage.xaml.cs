﻿using Generify.Contracts;
using Generify.Contracts.Page;
using Generify.Logic.ViewModel;
using Generify.Page.Base;
using Xamarin.Forms.Xaml;

namespace Generify.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : BasePage, IMainPage
	{
		public MainPage()
		{
			InitializeComponent();
			ViewModel = new MainPageViewModel();
			InitBindingContext();
		}

		protected override IViewModel ViewModel { get; set; }
	}
}