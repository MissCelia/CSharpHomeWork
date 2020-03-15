using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
	public class Node<T>
	{
		public Node<T> Next { get; set; }
		public T Data { get; set;}

		public Node(T t)
		{
			Next = null;
			Data = t;
		}
	}

	class GenericList<T>
	{
		private Node<T> head;
		private Node<T> tail;

		public GenericList() {   //构造函数
			tail = head = null;
		}

		public Node<T> Head { get => head; }  //属性

		public void Add(T t) {
			Node<T> node = new Node<T>(t);
			if (tail == null)
				head = tail = node;
			else
			{
				tail.Next = node;
				tail = node;
			}
		}

		public void ForEach(Action<T>action)
		{
			Node<T> node = head;
			while (node != null)
			{
				action(node.Data);
				node = node.Next;
			}
		}
	}
}
