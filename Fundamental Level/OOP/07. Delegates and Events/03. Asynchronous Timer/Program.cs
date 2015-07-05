using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Asynchronous_Timer
{
	class Program
	{
		static void Main(string[] args)
		{
			var timer1 = new AsyncTimer(
				() => {
					Console.WriteLine("timer 1 tick");
				},
				2000,
				5
			);
			timer1.Run();

			var timer2 = new AsyncTimer(
				() =>
				{
					Console.WriteLine("timer 2 tick");
				},
				1000,
				10
			);
			timer2.Run();

			while (true)
			{
				if (Console.KeyAvailable)
				{
					break;
				}

				// to slow down main methood printing
				for (int i = 0; i < 1000000; ++i)
				{
				}

				Console.WriteLine("press any key to exit");
			}
		}
	}
}
