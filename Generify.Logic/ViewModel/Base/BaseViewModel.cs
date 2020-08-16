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

		public Dictionary<string, ICommand> Commands
		{
			get { return Get<Dictionary<string, ICommand>>(); }
			set { Set(value); }
		}

		public class BaseParameter
		{
		}
	}
}
