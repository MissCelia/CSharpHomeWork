using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
	class OrderService
	{
		List<Order> orderList;
		internal List<Order> OrderList { get => orderList; set => orderList = value; }

		public OrderService(List<Order> OL) {
			orderList=OL;
		}

		//查询
		public IEnumerable<Order> OrderQuery(List<Order> orders, int item)  //按OrderNumber
		{
			var query = from o in orders
						where o.OrderNumber == item
						orderby o.Amount
						select o;
			return query;
		}
		public IEnumerable<Order> OrderQuery(List<Order> orders, double item)   //按Amount
		{
			var query = from o in orders
						where o.Amount == item
						orderby o.Amount
						select o;
			return query;
		}

		//添加
		public void OrderAdd(Order newOrder) {

			if (orderList.Find(o => o.Equals(newOrder)) == null)
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
		public IEnumerable<Order> OrderModify(int ordernumber,List<OrderItem> newitem,List<Order>orderlist) {
			foreach (Order order in orderlist)
				if (order.OrderNumber == ordernumber)
					order.Item = newitem;
			return orderlist;
		}

		//排序
		public void OrderSort() {
			
			orderList.OrderBy(a=>a.OrderNumber);
		}

		//查看
		public void OrderChack() {
			foreach(Order o in orderList)
				Console.WriteLine(o.ToString()+"\r\n");
		}

		
	}
}
