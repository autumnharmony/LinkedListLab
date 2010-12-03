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
		
		#region constructors
		
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
		
		#endregion
		
		
		#region operators ++ ==
		
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
		/*
		public static Node operator== (Node n1, Node n2){
			return (n1.Info == n2.Info);
		}
		
		public static Node operator!= (Node n1, Node n2){
			return !(n1.Info == n2.Info);
		}
		*/
		#endregion
		
		
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
		public override int GetHashCode(){
			return this.Info;
		}
		
		public override bool Equals(Object o){
			Node n = o as Node;
			return (this.Info==n.Info);
		}
		*/

	}
}



