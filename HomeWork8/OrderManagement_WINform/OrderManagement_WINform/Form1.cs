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
	public partial class Form1 : Form
	{
		OrderService orderService;
		private string input;
		public string Input { get => input; set => input = value; }


		public Form1()
		{
			InitializeComponent();
			
			//cbField.SelectedIndex = 0;
			//txtValue.DataBindings.Add("Text", this, "Keyword");

			OrderItem item1 = new OrderItem("ship", 1, 1);
			OrderItem item2 = new OrderItem("car", 1, 1);
			OrderItem item3 = new OrderItem("battery", 1, 1);
			OrderItem item4 = new OrderItem("ship", 1, 1);
			List<OrderItem> itemlist1 = new List<OrderItem> { item1,item2 };
			List<OrderItem> itemlist2 = new List<OrderItem> { item3,item4 };
			Order order1 = new Order(000, "Sam", itemlist1);
			Order order2 = new Order(521, "Jam", itemlist2);
			Order order3 = new Order(002, "Sara", itemlist2);
			List<Order> orderlist = new List<Order> { order1, order2, order3 };
			orderService = new OrderService(orderlist);
			orderDataBinding.DataSource = orderService.OrderList;
			
			
			textBox1.DataBindings.Add("Text", this, "Input");
				
		}

		
		private void quary_Click(object sender, EventArgs e)
		{

			switch (comboBox1.SelectedIndex)
			{
				case 0:
					orderDataBinding.DataSource = orderService.OrderList;
					break;
				case 1:
					orderDataBinding.DataSource = orderService.OrderQuery(OrderService.Attribute.OrderNumber,Input);
					break;
				case 2:
					orderDataBinding.DataSource = orderService.OrderQuery(OrderService.Attribute.CustomerName,Input);
					break;
				case 3:
					orderDataBinding.DataSource = orderService.OrderQuery(OrderService.Attribute.GoodsName,Input);
					break;
				

				default:
					orderDataBinding.DataSource = orderService.OrderList;
					break;
			}
			orderDataBinding.ResetBindings(true);
		}

	

		private void delete_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				int num = int.Parse(s);
				orderService.OrderDel(num);
				//orderDataBinding.ResetBindings(true);
				QueryAll();
				MessageBox.Show("删除成功！");
			}
			else
				MessageBox.Show("未选中任何订单！");
		}


		private void add_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			if (form2.ShowDialog() == DialogResult.OK)
			{
				orderService.OrderAdd(form2.CurrentOrder);
				QueryAll();
			}
		}

		

		private void export_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();			
			orderService.Export(saveFile.FileName);
		}

		private void QueryAll()
		{
			orderDataBinding.DataSource = orderService.OrderList;
			orderDataBinding.ResetBindings(false);
		}

		//修改
		private void EditOrder()
		{
			Order order = orderDataBinding.Current as Order;
			if (order == null)
			{
				MessageBox.Show("请选择一个订单进行修改");
				return;
			}
			Form2 form2 = new Form2(order, true);
			if (form2.ShowDialog() == DialogResult.OK)
			{
				orderService.OrderModify(form2.CurrentOrder);
				QueryAll();
			}
		}
		private void modify_Click(object sender, EventArgs e)
		{
			EditOrder();

		}
	}
}
