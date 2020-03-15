using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
	class Program
	{
		static void Main(string[] args)
		{
			string Time = DateTime.Now.ToString();
			Console.WriteLine("现在的时间是" + Time);
			Console.Write("设定的闹钟时间是：");
			String time = Console.ReadLine();
			Frame frame = new Frame();
			frame.clock.ClockAlarm(time);
			Console.ReadKey();
		}
	}
}
