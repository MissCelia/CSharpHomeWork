using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private List<double> value_list = new List<double>();//存放用户输入的数字
		private List<char> op_list = new List<char>();  //存放用户输入的运算符



		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";
		}

		private void button11_Click(object sender, EventArgs e)
		{
			textBox1.Text += "6";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text += "0";
		}

		private void button16_Click(object sender, EventArgs e)
		{
			
			value_list.Add(double.Parse(textBox1.Text));
			textBox1.Clear();
			op_list.Add('+');
			
		}

		private void button15_Click(object sender, EventArgs e)
		{
			value_list.Add(double.Parse(textBox1.Text));
			textBox1.Clear();
			op_list.Add('-');
		}

		private void button14_Click(object sender, EventArgs e)
		{
			value_list.Add(double.Parse(textBox1.Text));
			op_list.Add('*');
			textBox1.Clear();

		}

		private void button13_Click(object sender, EventArgs e)
		{
			value_list.Add(double.Parse(textBox1.Text));
			op_list.Add('/');
			textBox1.Clear();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			

			value_list.Add(double.Parse(textBox1.Text));
			double total = value_list[0];
			for (int i = 0; i < op_list.Count; i++)
			{
				char op = op_list[i];
				switch (op)
				{
					case '+':
						total += value_list[i + 1];
						break;
					case '-':
						total -= value_list[i + 1];
						break;
					case '*':
						total *= value_list[i + 1];
						break;
					case '/':
						total /= value_list[i + 1];
						break;
					
				}

			}
			textBox1.Text += "=";
			textBox1.Text = total + "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			op_list.Clear();    //清空累计的运算符和运算结果组的列表
			value_list.Clear();
			textBox1.Clear();
		}
	}
}
