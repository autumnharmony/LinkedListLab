﻿/*
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

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			try {
				SingleLinkedList sl1= listView1.GetList();
				SingleLinkedList sl2= listView2.GetList();
				SingleLinkedList sl3= listView3.GetList();
			
			
			SuspendLayout();
			ouput.Text += sl1.ToString();
			
			sl1.First = ListManager.Replace(sl1.First,sl2.First,sl3.First);
			
			
			ouput.Text += "\n";
			ouput.Text += sl1.ToString();
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
	}
}