using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Asynchronous_Timer
{
	class AsyncTimer
	{
		private Action action;
		private int ticks;
		private int interval;

		public AsyncTimer(Action action, int ticks, int interval)
		{
			this.Action = action;
			this.Ticks = ticks;
			this.Interval = interval;
		}

		public Action Action
		{
			get
			{
				return this.action;
			}
			set
			{
				this.action = value;
			}
		}

		public int Ticks
		{
			get
			{
				return this.ticks;
			}
			set
			{
				this.ticks = value;
			}
		}

		public int Interval
		{
			get
			{
				return this.interval;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException();
				}
				this.interval = value;
			}
		}

		public async void Run()
		{
			await Task.Run(() =>
			{
				ActionTask();
			});
		}

		private void ActionTask()
		{
			for (int i = 0; i < this.Ticks; ++i)
			{
				Thread.Sleep(this.Interval);

				if (this.Action != null)
				{
					this.Action();
				}
			}
		}
	}
}
