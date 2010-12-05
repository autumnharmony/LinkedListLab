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
				bool matched = true;
				bool first = true;
				/*
				if (F1.Info == F2.Info){
					#region если вхождение в самом начале

					p = F1;
					pp = F2;
					
					//Node t = p;
					
					//bool matched = true;
					
					while (pp!=null && p!=null){
						//if p.Info !=pp.Info)
						
						//if (first) prep = p; else {prep = prep.Link; first = false;}
						if (p.Info != pp.Info) {matched = false; break;}
						p=p.Link;
						pp=pp.Link;
					}
					
					// bp
					if (matched) {

						// нашли вхождение
						
						MessageBox.Show("нашли вхождение");
						
						
						q = (Node)F3.Clone();
						F1 = q;
						while (q.Link!=null){
							q=q.Link;
						}
						q.Link = p.Link;
					}
					
					else {
						p = F1.Link;
						prep = F1;
					}
					
					#endregion
				}
				 */
				prep = F1;
				p = F1.Link;
				
				while (p!=null){
					//bp
					if (p.Info == F2.Info){
						
						// запомнили начало
						Node s = p;
						
						pp = F2;
						
						matched = true;
						
						while (pp!=null && p!=null){
							matched = true;
							if (pp.Info!=p.Info) {
								matched = false;
								break;
							}
							
							else {
								//bp
								matched = true;
								pp = pp.Link;
								p = p.Link;
							}
						}
						
						if (matched) {

							//MessageBox.Show("нашли вхождение");
							
							q = (Node)F3.Clone();
							
							while (q.Link!=null){
								q=q.Link;
							}
							
							q.Link = p;
							prep.Link = q;
							prep = q;
							//p = p.Link;
						}
						
						else {
							prep = s;
							p = s.Link;
						}
					}
					
					else {
						prep = p;
						p = p.Link;
						
					}
					//if (p!=null && matched) 
					//if (matched)	p = p.Link;
					//if (pp.Link!=null && pp !=null)pp = pp.Link;
					
				}
				
			}
			
			return F1;
			
		}
	}
}

