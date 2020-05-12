using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace OrderManagement.Tests
{
	[TestClass()]
	public class OrderServiceTests
	{
		OrderService newService = new OrderService();
		OrderItem item1 = new OrderItem("ship", 1, 1);
		OrderItem item2 = new OrderItem("car", 1, 1);
		OrderItem item3 = new OrderItem("battery", 1, 1);
		OrderItem item4 = new OrderItem("ship", 1, 1);

		[TestInitialize()]
		public void init()
		{
			Order order1 = new Order(521, "Sam", new List<OrderItem> { item1, item2 });
			Order order2 = new Order(000, "Jam", new List<OrderItem> { item3 });
			newService = new OrderService();
			newService.OrderAdd(order1);
			newService.OrderAdd(order2);
		}


		[TestMethod()]
		public void OrderAddTest()
		{
			Order order3 = new Order(002, "Sara", new List<OrderItem> { item4 });
			newService.OrderAdd(order3);
			CollectionAssert.Contains(newService.OrderList, order3);
		}



		[TestMethod()]
		public void OrderSortTest()
		{
			newService.OrderSort();
			Assert.AreEqual(newService.OrderList[1].OrderNumber, 521);
			Assert.AreEqual(newService.OrderList[0].OrderNumber, 000);
		}



		[TestMethod()]
		public void OrderModifyTest()
		{
			Order order2 = new Order(521, "newJam", new List<OrderItem> { item3, item4 });
			newService.OrderModify(order2);

			Assert.AreEqual(order2.Customer, newService.GetOrder(521).Customer);
		}



		[TestMethod()]
		public void OrderDelTest()
		{
			newService.OrderDel(002);
			Assert.AreEqual(2, newService.OrderList.Count());
			//Assert.IsNull(newService.OrderQuery(OrderService.Attribute.OrderNumber, "002"));
		}


		[TestMethod()]
		public void OrderQueryTest()
		{
			List<Order> o= newService.OrderQuery(OrderService.Attribute.CustomerName, "Sam");
			Assert.AreEqual(o[0].OrderNumber, 521);
		}
	}
}