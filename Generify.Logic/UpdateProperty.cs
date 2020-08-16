using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Generify.Logic
{
	public abstract class UpdateProperty : INotifyPropertyChanged
	{
		private readonly IDictionary<string, object> _properties = new Dictionary<string, object>();
		protected T Get<T>([CallerMemberName] string property = null)
		{
			_properties.TryGetValue(property, out object value);
			return (T)value;
		}

		protected void Set<T>(T value, [CallerMemberName] string property = null)
		{
			if (!_properties.ContainsKey(property))
			{
				_properties[property] = value;
				OnPropertyChanged(property);
			}
		}

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
