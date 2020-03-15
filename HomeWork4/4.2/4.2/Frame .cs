using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
	class Frame
	{
		public Clock clock = new Clock();
		public Frame()
		{
			clock.OnTick += Frm_OnTick;
			clock.OnAlarm += Frm_OnAlarm;
		}
		void Frm_OnTick()
		{
			Console.WriteLine("Tik-Tak");
		}
		void Frm_OnAlarm()
		{
			Console.WriteLine("Time's up");
		}
	}
}
