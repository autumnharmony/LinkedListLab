/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 18.11.2010
 * Time: 18:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LinkedListLab
{
	/// <summary>
	/// Узел односвязного списка
	/// </summary>
	public class Node:ICloneable
	{
		int info;
		public int Info{
			set { info = value;}
			get { return info;}
		}
		
		Node link;
		
		public Node Link {
			set { link = value;}
			get { return link;}
		}
		
		
		public Node()
		{
		}
		
		public Node(int d)
		{
			Info = d;
		}
		
		public Node(int d, Node l)
		{
			Info = d;
			Link = l;
		}
		
		// FIXME: работает?
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		/// 
		public static Node operator++ (Node n){
			return n.Link;
		}
		
		
		
		
		public object Clone()
		{
			
			
			Node p = this.Link;
			
			Node First;
			Node last;
			
			First = new Node(this.Info,null);
			
			last = First;
			
			while (p!=null){
				last.Link = new Node(p.Info,null);
				last = last.Link;
				p = p.Link;
			}
			
			return First;

		}
		/*
			Node f = new Node(this.Info);
			Node p;
			
			
			while (this.Link!=null){
				q = new Node(this.Info);
			}
			while ()
			while ()
		 */
	}
}



