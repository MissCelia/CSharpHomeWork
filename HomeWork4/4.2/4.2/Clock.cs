using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
	public delegate void ClockHandler();
	class Clock
	{
		public event ClockHandler OnTick;
		public event ClockHandler OnAlarm;
		public void ClockAlarm(string x)
		{
			Console.WriteLine("闹钟设定的时间是"+x);
			bool flag = true;
			while (flag)
			{
				string time = DateTime.Now.ToString();
				Console.Write("现在的时间是" + time);
				if (time == x)
				{
					OnAlarm();
					flag = false;
					break;
				}
				OnTick();
				System.Threading.Thread.Sleep(1000);

			}
		}


	}
}
