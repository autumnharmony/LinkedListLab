﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace LinkedListLab
{
	/// <summary>
	/// Description of ListManager.
	/// </summary>
	public class ListManager
	{
		
		Log log;
		public ListManager(Log log)
		{
			this.log = log;
		}
		
		/// <summary>
		/// Заменяет ? все вхождения одного списка в другой третьим списком
		/// 
		/// 1, 2, 3 , 4, 5, 1, 2, 3, 6
		/// 1, 2, 3
		/// 10, 20.
		/// 
		/// 10, 20, 4, 5, 10, 20, 6.
		/// </summary>
		public static  Node Replace(Node F1, Node F2, Node F3){

			if (F1!=null && F2!=null && F3!=null){
				
				Node p = F1;
				Node pp = null;
				Node q = null;
				
				Node prep = F1;
				bool matched = false;

				//FIXME: работает, вроде
				
				if (F1.Info == F2.Info){
					#region если вхождение в самом начале
					
					Debug.WriteLine("предположительно есть совпадение в начале");
					
					p = F1;
					pp = F2;
					
					//Node t = p;
					
					matched = false;
					
					while (pp!=null && p!=null){
						
						matched = true;
						
						if (p.Info != pp.Info) {
							matched = false;
							continue; 
						}
						//else{
						//matched = true;
						p=p.Link;
						pp=pp.Link;
						//}
						Debug.WriteLine("!!! p ="+p);
					}
					
					// bp
					if (matched) {

						// нашли вхождение
						Debug.WriteLine("и правда, есть вхождение в начале, меняем");
						q = (Node)F3.Clone();
						F1 = q;
						while (q.Link!=null){
							q=q.Link;
						}
						q.Link = p;
						
						prep = q;
						//p = q.Link;
						//Debug.WriteLine("prep ="+prep.Info+" p="+p.Info);
					}
					
					else {
						Debug.WriteLine("встретилась "+p.Info+"ложная тревога, переходим в "+F1.Link.Info);
						prep = F1;
						p = F1.Link;
					}
					
					#endregion
				}
				/*
				else {
					prep = F1;
					p = F1.Link;
				}
				 */
				
				#region середина и конец
				
				while (p!=null){
					Debug.WriteLine(p.Info+"");
					if (p.Info == F2.Info){
						Debug.WriteLine("преположительно вхождение");
						
						// запомнили начало
						Node s = p;
						
						pp = F2;
						
						matched = true;
						
						while (pp!=null && p!=null){
							
							//if (){
								
								matched = true;
								if (pp.Info!=p.Info) {
									Debug.WriteLine(pp.Info + "!="+p.Info);
									matched = false;
									break;
								}
								
								
								matched = true;
								//else {
								//	matched = true;
								pp = pp.Link;
								p = p.Link;
								
								if (p == null) { 
									matched = false; 
									break;
								}
								//}
								
								//matched = true;
							//}
							/*
							else {
								matched = false;
								break;
							}
							*/
						}
						
						if (matched) {
							Debug.WriteLine("и правда, меняем");
							q = (Node)F3.Clone();
							
							prep.Link = q;
							
							while (q.Link!=null){
								q=q.Link;
							}
							
							q.Link = p;
							//prep.Link = q;
							prep = q;
							//p = p.Link;
							
							Debug.WriteLine("prep = "+prep + " p = "+p);
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
					
				}
				
				#endregion
				
			}
			
			return F1;
			
		}
		
		// идем по 1 списку с начала, если встретился элемент, у которого инф поле равно инф полю первого
		// элемента 2-го списка, то идем и сравниваем поэлементно, если нашли отличие выходим продолжаем
		// проход по первому списку с элемента следующего за
	}
}

