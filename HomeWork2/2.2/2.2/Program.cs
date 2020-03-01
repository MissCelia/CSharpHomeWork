using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和

namespace _2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("请输入数组长度：");
			int len = int.Parse(Console.ReadLine());
			Console.WriteLine("请输入{0}个值", len);
			//定义一个数组
			int[] array = new int[len];
			//给数据添加值
			for (int i = 0; i < len; i++)
			{
				array[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.Write("数组的最大值为" + array.Max()+"\n");
			Console.Write("数组的最小值为" + array.Min() + "\n");
			Console.Write("数组的平均值为" + array.Average() + "\n");
			Console.Write("数组元素之和为" + array.Sum() + "\n");
		}
	}
}
