using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Generify.View
{
	public class StackLayoutClick : StackLayout
	{
		public StackLayoutClick()
		{
			GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(CmdTapped)
			}); 
		}

		private void CmdTapped()
		{
			TappedCommand?.Execute(TappedCommandParameter);
		} 

		public BindableProperty TappedCommandProperty = BindableProperty.Create
		(
			propertyName: nameof(TappedCommand),
			returnType: typeof(ICommand),
			declaringType: typeof(StackLayoutClick),
			propertyChanged: null
		);

		public BindableProperty TappedCommandParameterProperty = BindableProperty.Create
		(
			propertyName: nameof(TappedCommandParameter),
			returnType: typeof(string),
			declaringType: typeof(StackLayoutClick),
			propertyChanged: null
		);

		public ICommand TappedCommand
		{
			get { return (ICommand)GetValue(TappedCommandProperty); }
			set { SetValue(TappedCommandProperty, value); }
		}

		public string TappedCommandParameter
		{
			get { return (string)GetValue(TappedCommandParameterProperty); }
			set { SetValue(TappedCommandParameterProperty, value); }
		}
	}
}
