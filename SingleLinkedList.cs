/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 18.11.2010
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LinkedListLab
{
	/// <summary>
	/// Односвязный нециклический список
	/// </summary>
	public class SingleLinkedList
	{
		Node first;
		public Node First {
			set { first = value; }
			get { return first; }
		}
		
		public bool isEmpty {
			get { 
				if (First==null) return true;
				return false; 
			}
		}
		public SingleLinkedList()
		{
			
		}
		
		public SingleLinkedList(int[] data)
		{
			Node p;
			first = null;
			for (int i=0;i<data.Length;i++){
				p = new Node(data[i],first);
				first = p;
			}
			
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="data">строка вида 1 2 3 4 5 6</param>
		public SingleLinkedList(string data){
			string[] sa = data.Split(' ');
			
			int[] a = new int[sa.Length];
			                 
			for (int i = 0; i<sa.Length; i++){
				a[i] = int.Parse(sa[i]);
			}
			
			Node last;
			if (a.Length == 0) first = null;
			else {
				First = new Node(a[0],null);
				last = First;
				for (int i=1;i<a.Length;i++){
					last.Link = new Node(a[i],null);
					last = last.Link;
				}
			}
		
			
		}
		
		public void Create(int[] data){
			Node last;
			if (data.Length == 0) first = null;
			else {
				First = new Node(data[0],null);
				last = First;
				for (int i=1;i<data.Length;i++){
					last.Link = new Node(data[i],null);
					last = last.Link;
				}
			}
		}
		/*
		public void Create2(int[] data){
			Node p = new Node(int[] data);
			first = p;
			Node last = p;
			last.Link = null;
			for (int i=1;i<data.Length;i++){
				Node p = new Node(data[i],null);
				last.Link = p;
				last = p;
			}
		
		}
		*/
		
		public void DeleteFirst(){
			if (first!=null){
				first = first.Link;
			}
		}
		
		public Node DeleteFirstAndGet(){
			Node p = first;
			if (first!=null)
				first = first.Link;
			return p;
		}
		
		public int Count(){
			Node p = first;
			int cnt = 0;
			while (p!=null){
				cnt++;
				p=p.Link;
			}
			return cnt;
		}
		
		public void InsertAfterLast(int d){
			if (first!=null){
				Node p = first;
				while (p.Link!=null){
					p = p.Link;
				}
				p.Link = new Node(d,null);
			}
			else first = new Node(d,null);
		}
		
		public void InsertAfter(Node p,int d){
			if (p!=null) {
				p.Link = new Node(d,p.Link);
			}
		}
		
		public void DeleteAfter(Node p){
			if(p!=null && p.Link!=null){
				p.Link = p.Link.Link;
			}
		}
		
		public Node DeleteAfterAndGet(Node p){
			Node Q = null;
			if (p!=null && p.Link!=null){
				Q = p.Link;
				p.Link = Q.Link;
			}
			return Q;
		}
		
		public override string ToString()
		{
			string s = "";
			Node p = First;
			
			while (p!=null)
			{
				s+=p.Info+"->";
				p = p.Link;
			}
			
			return s;
		}
			
		
		// TODO: Add Find node method
		
	}
}
