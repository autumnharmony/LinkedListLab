/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 18.11.2010
 * Time: 21:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;


namespace LinkedListLab
{
	/// <summary>
	/// Description of ListManager.
	/// </summary>
	public class ListManager
	{
		
		
		public ListManager()
		{
		}
		
		/// <summary>
		/// Заменяет все вхождения одного списка в другой третьим списком
		/// 
		/// 1, 2, 3 , 4, 5, 1, 2, 3, 6
		/// 1, 2, 3
		/// 10, 20.
		/// 
		/// 10, 20, 4, 5, 10, 20, 6.
		/// </summary>
		public static Node Replace(Node F1, Node F2, Node F3){

			if (F1!=null && F2!=null && F3!=null){
				
				Node p;
				Node pp = null;
				if (F1.Info == F2.Info){
					
					p = F1;
					pp = F2;

					do {
						p=p.Link;
						pp=pp.Link;
					}
					
					while (p.Info == pp.Info && pp.Link!=null && p.Link!=null);
					
					if (pp.Link == null) {
						// нашли вхождение
							
						MessageBox.Show("нашли вхождение");
						
						
						Node q = (Node)F3.Clone();
						F1 = q;
						while (q.Link!=null){
							q=q.Link;
						}
						q.Link = p.Link;
						
						//F1 = q;
						
						
						
					}
					
					
					
					
				}
				
				
				
				
				

				
				Node prep = F1;
				p = F1.Link;
				
				
				do {
					if (p.Info == F2.Info){
						
						// запомнили начало
						Node s = p;
						
						pp = F2;
						
						do {
							
							p=p.Link;
							pp=pp.Link;
						}
						
						while (p.Info == pp.Info && pp.Link!=null);
						
						
						if (pp.Link == null) {
							// нашли вхождение
							MessageBox.Show("нашли вхождение");
							
							
							//prep.Link = (Node)F3.Clone();
							
							Node q = (Node)F3.Clone();
							prep.Link = q;
							while (q.Link!=null){
								q=q.Link;
							}
							q.Link = p.Link;
							//prep.Link = q;
							
						}
						
						p = p.Link;
						pp = pp.Link;
					}
					while (p==null && pp==null);
					
					
					
					
					p = p.Link;
					prep = prep.Link;
				} while (p!=null);
				
				/*
					if (p.Info == F2.Info){
					
					// запомнили начало
					Node s = p;
					
					Node pp = F2;
					
					do {
						p = p.Link;
						pp = pp.Link;
					}
					while (p.Info == pp.Info && pp!=null);
					
					
					if (pp ==null) {
						// нашли вхождение
						
					}
				 */
			}
			return F1;
		}
		
	}
}

