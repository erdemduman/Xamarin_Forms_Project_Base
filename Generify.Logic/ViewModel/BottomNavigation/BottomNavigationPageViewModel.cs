using Generify.Logic.ViewModel.Base;
using Generify.Logic.ViewModel.BottomNavigation.ViewModule;
using Generify.Logic.ViewModel.BottomNavigation.ViewModule.Base;
using System;
using System.Collections.Generic;
using System.Dynamic;
using Xamarin.Forms.Internals;

namespace Generify.Logic.ViewModel.BottomNavigation
{
	public class BottomNavigationPageViewModel : BaseViewModel
	{
		private readonly Dictionary<string, BaseViewModule> _modules = new Dictionary<string, BaseViewModule>
		{
			{"Home", new HomeViewModule() },
			{"Playlist", new PlaylistViewModule() },
			{"Notifications", new NotificationsViewModule() },
			{"Profile", new ProfileViewModule() }
		};

		private BaseViewModule _currentModule;

		public override void OnCreate(object navigationData)
		{
			base.OnCreate(navigationData);
			InitTabSelection();
			SetCommand<string>("TabSelected", CmdTabSelected);
			MyText = "Blablabla";
		}

		#region Commands
		public void CmdTabSelected(string tab)
		{
			IsTabSelected.ForEach(item => { IsTabSelected[item.Key] = tab == item.Key ? true : false; });
			_currentModule = _modules[tab];
		}
		#endregion

		#region Helpers
		public void InitTabSelection()
		{
			IsTabSelected["Home"] = true;
			IsTabSelected["Playlist"] = false;
			IsTabSelected["Notifications"] = false;
			IsTabSelected["Profile"] = false;
			_currentModule = _modules["Home"];
		}
		#endregion

		#region Properties
		public Dictionary<string, bool> IsTabSelected
		{
			get { return Get<Dictionary<string, bool>>(); }
			set { Set(value); }
		}

		public string MyText { get; set; }
		#endregion

		public class Parameter : BaseParameter
		{

		}
	}
}
