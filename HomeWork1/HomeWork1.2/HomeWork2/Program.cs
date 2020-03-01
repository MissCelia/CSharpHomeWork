using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Addition1, Addition2, Symbol;
            int num1, num2, num3 = 0;
            Console.WriteLine("请输入第一个参与运算的数字");
            Addition1 = Console.ReadLine();
            Console.WriteLine("请输入运算符号:");
            Symbol = Console.ReadLine();
            Console.WriteLine("请输入第二个参与运算的数字");
            Addition2 = Console.ReadLine();
            num1 = int.Parse(Addition1);
            num2 = int.Parse(Addition2);
            if (Symbol == "+")
            {
                num3 = num1 + num2;
            }
            else if (Symbol == "-")
            {
                num3 = num1 - num2;
            }
            else if (Symbol == "/")
            {
                num3 = num1 / num2;
            }
            else if (Symbol == "*")
            {
                num3 = num1 * num2;
            }
            Console.WriteLine("结果是:");
            Console.WriteLine(num3.ToString());
            Console.ReadKey();

        }
    }
}
