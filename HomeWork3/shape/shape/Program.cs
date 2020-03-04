
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace shape
{
	class Program
	{
		static void Main(string[] args)
		{
			double areasum = 0;

			Console.WriteLine("输入三角形的数量：");
			for (int num = int.Parse(Console.ReadLine()); num > 0; num--)
			{
				shape trishape = ShapeFactory.CreateShape(ShapeType.Triangle);
				areasum += trishape.Get_area();
			}

			Console.WriteLine("输入正方形的数量：");
			for (int num = int.Parse(Console.ReadLine()); num > 0; num--)
			{
				shape squshape = ShapeFactory.CreateShape(ShapeType.Triangle);
				areasum += squshape.Get_area();
			}

			Console.WriteLine("输入长方形的数量：");
			for (int num = int.Parse(Console.ReadLine()); num > 0; num--)
			{
				shape recshape = ShapeFactory.CreateShape(ShapeType.Triangle);
				areasum += recshape.Get_area();
			}

			Console.WriteLine("输入圆形的数量：");
			for (int num = int.Parse(Console.ReadLine()); num > 0; num--)
			{
				shape cirshape = ShapeFactory.CreateShape(ShapeType.Triangle);
				areasum += cirshape.Get_area();
			}

			Console.WriteLine("图形的面积之和为"+areasum);


		}
	}

	public interface shape
	{
		double Get_area();
		bool Islegal();
	}


	public class Rectangle : shape
	{
		private double length;
		private double width;

		public double Length { get => length; set => length = value; }
		public double Width { get => width; set => width = value; }

		public bool Islegal()
		{
			if (length > 0 && width > 0)
				return true;
			else
				return false;
		}
	
		public double Get_area()
		{
			if (this.Islegal())
				return length * width;
			else
				return -1;
		}

		public Rectangle(double l,double w) {
			Length = l;
			Width = w;
		}
	}


	public class Square : shape
	{
		private double edge;

		public double Edge { get => edge; set => edge = value; }

		public bool Islegal()
		{
			if (edge > 0)
				return true;
			else
				return false;
		}
		public double Get_area()
		{
			if (this.Islegal())
				return edge * edge;
			else
				return -1;
		}

		public Square(double e) {
			Edge = e;
		}
	}


	public class Circle : shape
	{
		double Pi = 3.14159265;
		double radius;
		public double Radius { get => radius; set => radius = value; }
		public bool Islegal() {
			if (radius > 0)
				return true;
			else
				return false;
		}

		public double Get_area()
		{
			if (this.Islegal())
				return Pi * radius * radius;
			else
				return -1;
		}

		public Circle(double r) {
			Radius = r;
		}
	}


	public class Triangle : shape
	{
		private double edge1;
		private double edge2;
		private double edge3;

		public double Edge1 { get => edge1; set => edge1 = value; }
		public double Edge2 { get => edge2; set => edge2 = value; }
		public double Edge3 { get => edge3; set => edge3 = value; }

		public bool Islegal()
		{
			if (Edge1 + Edge2 > Edge3 && Edge2 + Edge3 > Edge1 && Edge3 + Edge1 > Edge2)
				return true;
			else
				return false;
		}
		public double Get_area()
		{
			double p = edge1 + edge2 + edge3;
			if (this.Islegal())
				return Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
			else				
				return -1;
		}

		public Triangle(double e1, double e2, double e3) {
			Edge1 = e1;
			Edge2 = e2;
			Edge3 = e3;
		}
	}


	public enum ShapeType
	{
		Rectangle,
		Square,
		Circle,
		Triangle

	}

	public class ShapeFactory
	{
		public static shape CreateShape(ShapeType shapetype)
		{
			Random rd = new Random();
			if (shapetype == ShapeType.Circle)
			{
				return new Circle(rd.Next(1,10));
			}
			else if (shapetype == ShapeType.Rectangle)
			{
				return new Rectangle(rd.Next(1, 10), rd.Next(1, 10));
			}
			else if (shapetype == ShapeType.Triangle)
			{
				return new Triangle(rd.Next(1, 10), rd.Next(1, 10), rd.Next(1, 10));
			}
			else
			{
				return new Square(rd.Next(1, 10));
			}

		}
	}
}