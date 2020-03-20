 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			OrderItem item1 = new OrderItem("a", 1, 1);
			OrderItem item2 = new OrderItem("b", 1, 1);
			OrderItem item3 = new OrderItem("c", 1, 1);
			OrderItem item4 = new OrderItem("a", 1, 1);
			List<OrderItem> itemlist1 = new List<OrderItem> {item1 };
			List<OrderItem> itemlist2 = new List<OrderItem> { item2};
			Order order1 = new Order(000, "Sam", itemlist1);
			Order order2 = new Order(521, "Jam", itemlist2);
			

			List<Order> orderlist = new List<Order> { order1,order2};
			OrderService newService = new OrderService(orderlist);
			newService.OrderChack();
		}
	}
}
