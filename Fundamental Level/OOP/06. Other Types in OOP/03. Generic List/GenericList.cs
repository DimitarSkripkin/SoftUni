using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_List
{
	[CustomVersionAttribute(0, 1)]
	public class GenericList<T>//: IEnumerable<T>
			where T : IComparable<T>
	{
		private const int DefaultCapacity = 16;

		private int count;
		private T[] data;

		public GenericList(int capacity = DefaultCapacity)
		{
			//this.capacity = capacity;
			this.data = new T[0];
			EnsureCapacity(capacity);
		}

		public int Count
		{
			get
			{
				return this.count;
			}
		}

		public int Capacity
		{
			get
			{
				return this.data.Length;
			}
			set
			{
				if (this.Capacity < value)
				{
					if (value < 0 || value < this.count)
					{
						throw new IndexOutOfRangeException("New capacity can't be negative or less then GenericList<T>.Count");
					}

					T[] temp = data;

					this.data = new T[value];

					for (int i = 0; i < temp.Length; ++i)
					{
						this.data[i] = temp[i];
					}

					//Array.Clear(temp, 0, temp.Length);
				}
			}
		}

		private void EnsureCapacity(int size)
		{
			if (this.Capacity < size)
			{
				int newCapacity = this.data.Length == 0 ? DefaultCapacity : size * 2;
				if (newCapacity < size)
				{
					newCapacity = size;
				}
				this.Capacity = newCapacity;
			}
		}

		public void Add(T item)
		{
			EnsureCapacity(count + 1);
			data[count] = item;
			++count;
		}

		public T this[int index]
		{
			get
			{
				return this.data[index];
			}
			set{
				this.data[index] = value;
			}
		}

		public void Insert(int index, T item)
		{
			if (index < 0 || index > count)
			{
				// TODO:
				throw new IndexOutOfRangeException();
			}
			EnsureCapacity(this.count + 1);

			for (int i = this.count; i > index; --i)
			{
				this.data[i] = this.data[i - 1];
			}

			this.data[index] = item;
			++this.count;
		}

		public void Clear()
		{
			if (this.count > 0)
			{
				Array.Clear(this.data, 0, this.count);
			}
			this.count = 0;
		}

		public int IndexOf(T item)
		{
			for (int i = 0; i < this.count; ++i)
			{
				if (this.data[i].CompareTo(item) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		public bool Contains(T item)
		{
			if (IndexOf(item) < 0)
			{
				return false;
			}
			return true;
		}

		public void RemoveAll(T item)
		{
			for (int i = 0; i < this.count; ++i)
			{
				if (this.data[i].CompareTo(item) == 0)
				{
					RemoveAt(i);
					--i;
				}
			}
		}

		public void Remove(T item)
		{
			int index = IndexOf(item);
			if (index != -1)
			{
				RemoveAt(index);
			}
		}

		public void RemoveAt(int index)
		{
			if (index < 0 || index >= this.count)
			{
				// TODO:
				throw new IndexOutOfRangeException();
			}

			for (int i = index; i < this.count; ++i)
			{
				this.data[i] = this.data[i + 1];
			}
			--this.count;

			this.data[this.count] = default(T);
		}

		public T Min()
		{
			T min = this.data[0];

			for (int i = 1; i < this.count; ++i)
			{
				if (min.CompareTo(this.data[i]) > 0)
				{
					min = this.data[i];
				}
			}

			return min;
		}

		public T Max()
		{
			T max = this.data[0];

			for (int i = 1; i < this.count; ++i)
			{
				if (max.CompareTo(this.data[i]) < 0)
				{
					max = this.data[i];
				}
			}

			return max;
		}

		public override string ToString()
		{
			return string.Join(", ", data.Take(count));
		}
	}
}
