using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace OrderManagement
{	[Serializable]
	public class OrderItem
	{
		private string goodsname;
		private double price;
		private int quantity;
		public string Name { get => goodsname; set => goodsname = value; }
		public double Price { get => price; set => price = value; }
		public int Quantity { get => quantity; set => quantity = value; }
		public double totalprice { get => quantity*price; }
		public OrderItem() { }
		public OrderItem(string name,double price,int quantity)
		{
			Name = name;
			Price = price;
			Quantity = quantity;
		}

		public override bool Equals(object obj)
		{
			var item = obj as OrderItem;
			return item != null &&
				   goodsname == item.goodsname &&
				   price == item.price &&
				   quantity == item.quantity &&
				   Name == item.Name &&
				   Price == item.Price &&
				   Quantity == item.Quantity;
		}

		public override int GetHashCode()
		{
			var hashCode = -591053104;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(goodsname);
			hashCode = hashCode * -1521134295 + price.GetHashCode();
			hashCode = hashCode * -1521134295 + quantity.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
			hashCode = hashCode * -1521134295 + Price.GetHashCode();
			hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
			return hashCode;
		}

		public override string ToString()
		{
			return "Item name:"+Name+"\r\n"+"Item Number:"+Quantity.ToString()+"\r\n"+"Item Price:"+Price;
		}

	}
}
