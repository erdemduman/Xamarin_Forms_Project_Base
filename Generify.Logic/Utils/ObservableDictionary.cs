using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace Generify.Logic.Utils
{
	public class ObservableDictionary<K, V> : Dictionary<K, V>, INotifyPropertyChanged
	{
		public new V this[K key]
		{
			get => GetValue(key);
			set => SetValue(key, value);
		}

		private V GetValue(K key)
		{
			TryGetValue(key, out V value);
			return value;
		}

		private void SetValue(K key, V value)
		{
			base[key] = value;
			OnPropertyChanged();
		}

		private void OnPropertyChanged(string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
