using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//编写程序输出用户指定数据的所有素数因子

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			string n;
			Console.WriteLine("输入一个整数:");
			n = Console.ReadLine();
			Console.WriteLine("它的所有素数因子为:");
			int x = int.Parse(n);
			while (x > -1)
			{
				int j = (int)Math.Sqrt(x);
				int i = 0;
				for (i = 2; i <= j; i++)
				{
					if (x % i == 0)
					{
						Console.WriteLine(i);
						x = x / i;
						break;
					}
				}
				if (i > j)
				{
					Console.WriteLine(x);
					break;
				}
			}
		}


	}
}
