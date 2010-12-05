/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 19.11.2010
 * Time: 3:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LinkedListLab
{
	/// <summary>
	/// Description of ListView.
	/// </summary>
	public partial class ListView : UserControl
	{
		SingleLinkedList list;
		
		public bool Editable = true;
		
		public ListView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public ListView(int[] d)
		{
			
			
			InitializeComponent();
			
			
		}
		
		void AddBtnClick(object sender, EventArgs e)
		{
			itemsTlp.RowCount++;
			TextBox tb = new TextBox();
			tb.Width = 30;
			itemsTlp.Controls.Add(tb);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (itemsTlp.Controls.Count>0){
			itemsTlp.Controls.RemoveAt(itemsTlp.Controls.Count-1);
			}
		}
		
		public SingleLinkedList GetList(){
		
			SingleLinkedList list = new SingleLinkedList();
			try {
			
			foreach(TextBox c in itemsTlp.Controls) {
				list.InsertAfterLast(int.Parse(c.Text));
			
			}
			}
				catch {}
				
			// TODO: обновление поля list при добавлении нового элемента в список, а не при вызове GetList
			this.list = list;
			return list;
			
			
		}
		
		public void SetList(SingleLinkedList list){
			SuspendLayout();
			this.list = list;
			Node p = list.First;
			while(p!=null){
				TextBox tb = new TextBox();
				tb.Text = p.Info.ToString();
				tb.Width = 30;
				this.itemsTlp.Controls.Add(tb);
				p = p.Link;
			}
			ResumeLayout();
			
			
		}
		
		void ListViewClick(object sender, EventArgs e)
		{
			
			MessageBox.Show(this.GetList().ToString());
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show(this.GetList().ToString());
		}
		
		void ListViewLoad(object sender, EventArgs e)
		{
			
		}
		
		void TlpPaint(object sender, PaintEventArgs e)
		{
			
		}
		
		void GbEnter(object sender, EventArgs e)
		{
			if (Editable)
			controlsTlp.Show();
		}
		
		void TmTick(object sender, EventArgs e)
		{
			controlsTlp.Height+=20;
		}
		
		void GbLeave(object sender, EventArgs e)
		{
			controlsTlp.Hide();
		}
		
		void TlpEnter(object sender, EventArgs e)
		{
			
		}
		
		void GbMouseHover(object sender, EventArgs e)
		{
			if (Editable)
			controlsTlp.Show();
		}
		
		void ItemsTlpMouseHover(object sender, EventArgs e)
		{
			if (Editable)
			controlsTlp.Show();
		}
		
		void ItemsTlpMouseLeave(object sender, EventArgs e)
		{
			
		}
		
		void TlpMouseHover(object sender, EventArgs e)
		{
			if (Editable)
			controlsTlp.Show();
		}
		
		void TlpMouseLeave(object sender, EventArgs e)
		{
			
		}
	}
}
