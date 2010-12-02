/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 18.11.2010
 * Time: 18:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LinkedListLab
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.ouput = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listView1 = new LinkedListLab.ListView();
			this.listView2 = new LinkedListLab.ListView();
			this.listView3 = new LinkedListLab.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ouput
			// 
			this.ouput.Location = new System.Drawing.Point(312, 119);
			this.ouput.Multiline = true;
			this.ouput.Name = "ouput";
			this.ouput.Size = new System.Drawing.Size(104, 74);
			this.ouput.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(312, 71);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.файлToolStripMenuItem,
									this.списокToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(445, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// списокToolStripMenuItem
			// 
			this.списокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.создатьToolStripMenuItem});
			this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
			this.списокToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.списокToolStripMenuItem.Text = "Список";
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.создатьToolStripMenuItem.Text = "Создать";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.СоздатьToolStripMenuItemClick);
			// 
			// listView1
			// 
			this.listView1.AutoSize = true;
			this.listView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.listView1.Location = new System.Drawing.Point(12, 71);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(87, 89);
			this.listView1.TabIndex = 3;
			// 
			// listView2
			// 
			this.listView2.AutoSize = true;
			this.listView2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.listView2.Location = new System.Drawing.Point(105, 71);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(87, 89);
			this.listView2.TabIndex = 4;
			// 
			// listView3
			// 
			this.listView3.AutoSize = true;
			this.listView3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.listView3.Location = new System.Drawing.Point(198, 71);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(87, 89);
			this.listView3.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(105, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "label2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(198, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "label3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 392);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView3);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ouput);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "LinkedListLab";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private LinkedListLab.ListView listView3;
		private LinkedListLab.ListView listView2;
		private LinkedListLab.ListView listView1;
		private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox ouput;
	}
}
