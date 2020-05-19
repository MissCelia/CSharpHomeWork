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
	public partial class Form2 : Form
	{
		public Order CurrentOrder { get; set; }

		//添加订单的构造函数
		public Form2()
		{
			CurrentOrder = new Order();
			InitializeComponent();
			orderBindingSource.DataSource = CurrentOrder;
		}
		//修改订单的构造函数
		public Form2(Order order, bool editMode = false) 
		{
			InitializeComponent();
			//TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
			CurrentOrder = order;
			orderBindingSource.DataSource = CurrentOrder;
			textBox1.Enabled = false;
			textBox2.Enabled = false;
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", CurrentOrder, "OrderNumber"));
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", CurrentOrder, "Customer"));
		}

		
		private void button1_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			//try
			//{
				if (form3.ShowDialog() == DialogResult.OK)
				{
					CurrentOrder.AddItem(form3.CurrentItem);
					itemBindingSource.ResetBindings(false);
				}
			//}
			//catch (Exception e2)
			//{
			//	MessageBox.Show(e2.Message);
			//}

		}



		private void btn_saveOrder_Click(object sender, EventArgs e)
		{
			if (textBox1.Enabled == true)
			{
				CurrentOrder.OrderNumber = int.Parse(textBox1.Text);
				CurrentOrder.Customer = textBox2.Text;
			}
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			OrderItem orderItem = itemBindingSource.Current as OrderItem;
			if (orderItem == null)
			{
				MessageBox.Show("未选中任何订单项");
				return;
			}
			CurrentOrder.DelItem(orderItem);
			MessageBox.Show("删除成功！");
			itemBindingSource.ResetBindings(false);
		}

	
		
		




	}
}
