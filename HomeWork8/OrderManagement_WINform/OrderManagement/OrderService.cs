using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManagement
{
	public class OrderService
	{
		List<Order> orderList;
		public List<Order> OrderList { get => orderList; set => orderList = value; }
		//XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));



		//构造函数
		public OrderService() {
			orderList = new List<Order>();
		}
		public OrderService(List<Order> OL) {
			orderList=OL;
		}

		public enum Attribute { CustomerName,OrderNumber,GoodsName}

		//查询
		public List<Order> OrderQuery(Attribute type,string item="")  //按OrderNumber
		{
			IEnumerable<Order> result = null;
			switch (type)
			{
				case Attribute.CustomerName:
					result = from o in OrderList
							 where o.Customer == item
							 orderby o.Amount
							 select o;
					break;
				case Attribute.GoodsName:
					result = from o in OrderList
							 where o.Item.Find(i=>i.Name.Equals(item))!=null //item.Find(o => o.Equals(newItem)) 
							 orderby o.Amount
							 select o;
					break;
				case Attribute.OrderNumber:
					result = from o in OrderList
							 where o.OrderNumber.ToString() == item
							 orderby o.Amount
							 select o;
					break;
			}
			List<Order> asList = result.ToList();
			return asList;
				
			
		}

		public Order GetOrder(int id)
		{
			return orderList.Where(o => o.OrderNumber == id).FirstOrDefault();
		}

		//添加
		public void OrderAdd(Order newOrder) {

			if (OrderList.Contains(newOrder))
				throw new ApplicationException($"Add Order Error: Order with id {newOrder.OrderNumber} already exists!");
			if(newOrder==null)
				throw new ApplicationException($"Add Order Error: Order is null");

			orderList.Add(newOrder);
		}
		//删除
		public void OrderDel(int ordernum) {
			int index = orderList.FindIndex(o => o.OrderNumber == ordernum);
			if (index != -1)
			{
				orderList.RemoveAt(index);
			}
			
		}


		//修改
		public void OrderModify(Order newOrder) {
			Order oldOrder = GetOrder(newOrder.OrderNumber);
			if (oldOrder == null)
				throw new ApplicationException($"Update Error：the order with id {newOrder.OrderNumber} does not exist!");
			OrderList.Remove(oldOrder);
			OrderList.Add(newOrder);					
		}

		//排序
		public void OrderSort() {

			orderList.Sort((a, b) => a.OrderNumber.CompareTo(b.OrderNumber));
		}

		//查看
		public void OrderChack() {
			foreach(Order o in orderList)
				Console.WriteLine(o.ToString()+"\r\n");
		}

		public void Export(string fileName) {
			XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));

			using (FileStream orderfile = new FileStream(fileName, FileMode.Create))
			{
				xmlserializer.Serialize(orderfile, OrderList);
				Console.WriteLine("\nSerialized as XML:");
				Console.WriteLine(File.ReadAllText(fileName));
			}
		}
		public void Import(string filePath) {
			XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));

			using (FileStream orderfile = new FileStream(filePath, FileMode.Open))
			{
				List<Order> list1 = new List<Order>();
				list1 = (List<Order>)xmlserializer.Deserialize(orderfile);
				//Console.WriteLine(list1 == null);				
				Console.WriteLine("\nDeserialized from XML:");
				foreach (Order o in list1)
				{
					Console.WriteLine(o.ToString() + "\r\n");
				}
			}
		}


	}
}
