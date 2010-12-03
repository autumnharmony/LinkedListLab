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
				
				
				Node p = F1;
				Node pp = null;
				Node q = null;
				Node prep = F1;
				
				bool first = true;
				
				if (F1.Info == F2.Info){
					//работает
					#region если вхождение в самом начале
					
					p = F1;
					pp = F2;
					
					
					while (p.Info == pp.Info && pp.Link!=null && p.Link!=null){
						//if p.Info !=pp.Info)
						if (first) prep = p; else {prep = prep.Link; first = false;}
						p=p.Link;
						pp=pp.Link;
					}
					
					// bp
					if (pp.Info == p.Info) {

						// нашли вхождение
							
						MessageBox.Show("нашли вхождение");
						
						
						q = (Node)F3.Clone();
						F1 = q;
						while (q.Link!=null){
							q=q.Link;
						}
						q.Link = p.Link;
						
						//F1 = q;
						
						
						
					}
					
					#endregion
				}
				
				
				//Node prep;
//				p = prep.Link;

				if (q == null){
					//prep = p;
					//p = p.Link;
				}
				else {
					prep = q;
					p = q.Link;
				}
//				Node prep = p;
				//p = p.Link;
				
				
				
				while (p!=null && p.Link!=null){
					
					if (p.Info == F2.Info){
						
						// запомнили начало
						//Node s = p;
						
						pp = F2;
						
						
						
						while (p.Info == pp.Info && pp.Link!=null && p.Link!=null)
						{
							p=p.Link;
							pp=pp.Link;
						}
						
						if (pp.Info == p.Info) {
							// нашли вхождение
							MessageBox.Show("нашли вхождение");
							
							
							//prep.Link = (Node)F3.Clone();
							
							q = (Node)F3.Clone();
							prep.Link = q;
							while (q.Link!=null){
								q=q.Link;
							}
							q.Link = p.Link;
							
							prep = q;
							p = q.Link;
							
						}
						
						//prep = p
						//p = p.Link;
						//prep = prep.Link;
					}
					//while (p==null && pp==null);
					
					
					
					prep = p;
					if (p!=null && p.Link != null) p = p.Link;
					//if (pp.Link!=null)pp = pp.Link;
					//prep = prep.Link;
				} 
				
			
			}
			return F1;
		}
		
	}
}

