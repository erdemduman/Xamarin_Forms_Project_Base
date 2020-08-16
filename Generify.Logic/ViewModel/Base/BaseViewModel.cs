using Generify.Contracts;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Generify.Logic.ViewModel.Base
{
	public abstract class BaseViewModel : UpdateProperty, IViewModel
	{
		protected BaseViewModel()
		{
		}

		#region LifeCycle
		public virtual void OnCreate(object NavigationData)
		{
			Commands = new Dictionary<string, ICommand>();
			Navigation = DependencyManager.Resolve<INavigationManager>();
		}

		public virtual void OnDestroy()
		{
		}
		#endregion

		#region Helpers
		public void SetCommand(string name, Action command)
		{
			if (Commands != null)
				Commands[name] = new Command(command);
		}

		public void SetCommand<T>(string name, Action<T> command)
		{
			if (Commands != null)
				Commands[name] = new Command<T>(command);
		}
		#endregion

		#region Properties
		public Dictionary<string, ICommand> Commands
		{
			get { return Get<Dictionary<string, ICommand>>(); }
			set { Set(value); }
		}

		public INavigationManager Navigation
		{
			get { return Get<INavigationManager>(); }
			set { Set(value); }
		}
		#endregion

		public class BaseParameter
		{
		}
	}
}
