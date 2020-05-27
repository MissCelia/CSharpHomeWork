using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OrderManagement
{
	[Serializable]
	public class Order
	{
		[Key]
		private int orderNumber;
		private string customer;
		private List<OrderItem> item;
		private double amount;
		public int OrderNumber { get => orderNumber; set => orderNumber = value; }
		public string Customer { get => customer; set => customer = value; }
		public List<OrderItem> Item { get => item; set => item = value; }
		public double Amount{
			get
			{
				amount = 0.0;
				if (item == null)
					amount = 0.0;
				else
				{
					foreach (OrderItem i in item)
						amount += i.Price * i.Quantity;
				}
				return amount;
				
			}
		}
		


		public Order() {
			Item = new List<OrderItem>();
		}
		public Order(int num,string cus,List<OrderItem> it) {
			orderNumber = num;
			customer = cus;
			Item = it;
		}
		
		public void AddItem(OrderItem orderItem)
		{
			if (Item.Contains(orderItem))
				throw new ApplicationException($"添加错误：订单项{orderItem.Name} 已经存在!");
			Item.Add(orderItem);
		}

		public void DelItem(OrderItem selItem) {
			
				item.Remove(selItem);
		}

		public override string ToString()
		{
			string s=null;
			foreach (OrderItem i in item)
				s = s + i.ToString() + "\r\n";
			return "Order Number:"+orderNumber+"\r\n"+"Customer:"+customer+"\r\n"+"Order Item:"+"\r\n"+s;
		}


		public override bool Equals(object obj)
		{
			var order = obj as Order;
			return order != null &&
				   orderNumber == order.orderNumber &&
				   customer == order.customer &&
				   EqualityComparer<List<OrderItem>>.Default.Equals(item, order.item) && 
				   OrderNumber == order.OrderNumber &&
				   Customer == order.Customer &&
				   EqualityComparer<List<OrderItem>>.Default.Equals(Item, order.Item);
		}

		public override int GetHashCode()
		{
			var hashCode = 1552032626;
			hashCode = hashCode * -1521134295 + orderNumber.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(customer);
			hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(item);
			hashCode = hashCode * -1521134295 + OrderNumber.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Customer);
			hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(Item);
			return hashCode;
		}
	}

}
