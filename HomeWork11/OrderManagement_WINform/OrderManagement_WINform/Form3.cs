using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;

namespace OrderManagement_WINform
{
	public partial class Form3 : Form
	{
		
		public OrderItem CurrentItem;
		public Form3()
		{
			InitializeComponent();
			CurrentItem = new OrderItem();
			itemBindingSource.DataSource = CurrentItem;
		}



		private void button1_Click(object sender, EventArgs e)
		{
			//if (CurrentItem == null)
			//{
				//CurrentItem.Name = textBox1.Text;
				//CurrentItem.Price = double.Parse(textBox2.Text);
				//CurrentItem.Quantity = int.Parse(textBox3.Text);
				//double temp = CurrentItem.Price * CurrentItem.Quantity;
				//textBox4.Text = temp.ToString();
			//}
			this.Close();
			
		}
	}
}
