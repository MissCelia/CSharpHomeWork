using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//为示例中的泛型链表类添加类似于List<T> 类的ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。
namespace _4._1
{
	class Program
	{
		static void Main(string[] args)
		{
			GenericList<int> list = new GenericList<int>();
			Random rnd = new Random();
			for (int i = 0; i < 10; i++)
			{				
				int t = rnd.Next(1, 100);
				list.Add(t);
			}

			list.ForEach(t => Console.WriteLine(t));

			int max = list.Head.Data;
			list.ForEach(t => max = t > max ? t : max) ;
			Console.WriteLine($"max:{max}");

			int min = list.Head.Data;
			list.ForEach(t => min = t > min ? min : t);
			Console.WriteLine($"min:{min}");
		}
	}
}
