using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Student_Class
{
	public delegate void PropertyChangeEventHandler(object obj, PropertyChangedEventArgs eventArgs);

	public class PropertyChangedEventArgs : EventArgs
	{
		private string propertyName;
		private dynamic oldValue;
		private dynamic newValue;

		public PropertyChangedEventArgs(string propertyName, dynamic oldValue, dynamic newValue)
		{
			this.PropertyName = propertyName;
			this.OldValue = oldValue;
			this.NewValue = newValue;
		}

		public string PropertyName
		{
			get { return propertyName; }
			set { propertyName = value; }
		}

		public dynamic OldValue
		{
			get { return oldValue; }
			set { oldValue = value; }
		}

		public dynamic NewValue
		{
			get { return newValue; }
			set { newValue = value; }
		}
	}
}
