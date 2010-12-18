/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 18.11.2010
 * Time: 18:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LinkedListLab
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		ListManager lm;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			rl.Editable = false;
			//Log l = new Log(log);
			//lm = new ListManager(l);

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.ouput.Clear();
			try {
				SingleLinkedList sl1; 
				SingleLinkedList sl2; 
				SingleLinkedList sl3; 
				
				
				
				sl1 = listView1.GetList();
				sl2 = listView2.GetList();
				sl3 = listView3.GetList();
				
				if (sl1.isEmpty && sl2.isEmpty && sl3.isEmpty) {
					
					
					if (textBox1.Text.Length!=0 && textBox2.Text.Length!=0 && textBox3.Text.Length!=0){
						sl1 = new SingleLinkedList(textBox1.Text.Trim());
						sl2 = new SingleLinkedList(textBox2.Text.Trim());
						sl3 = new SingleLinkedList(textBox3.Text.Trim());
					}
				}
				
				else {
				
					sl1 = new SingleLinkedList("1 1 1 1 2 1 1 2 3");
					sl2 = new SingleLinkedList("1 1 2");
					sl3 = new SingleLinkedList("0");
				}
			
			SuspendLayout();
			ouput.Text += sl1.ToString();
			
			sl1.First = ListManager.Replace(sl1,sl2,sl3);
			
			
			ouput.Text += "\r\n";
			ouput.Text += sl1.ToString();
			
			
			rl.SetList(sl1);
			
			
			ResumeLayout();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message+ ex.StackTrace);
			}
		}
		
		void ДанныеToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void СоздатьToolStripMenuItemClick(object sender, EventArgs e)
		{
			CreateListDialog cld = new CreateListDialog();
			cld.Show();
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			MessageBox.Show("Omg!");
		}
		
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 0;
		}
		
		void ToolStripMenuItem3Click(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 1;
		}
	}
}
