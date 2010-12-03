/*
 * Created by SharpDevelop.
 * User: anton
 * Date: 19.11.2010
 * Time: 3:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LinkedListLab
{
	partial class ListView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
			this.tlp = new System.Windows.Forms.TableLayoutPanel();
			this.itemsTlp = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.gb = new System.Windows.Forms.GroupBox();
			this.controlsTlp = new System.Windows.Forms.TableLayoutPanel();
			this.addBtn = new System.Windows.Forms.Button();
			this.tm = new System.Windows.Forms.Timer(this.components);
			this.tlp.SuspendLayout();
			this.gb.SuspendLayout();
			this.controlsTlp.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlp
			// 
			this.tlp.AutoSize = true;
			this.tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlp.BackColor = System.Drawing.SystemColors.ControlDark;
			this.tlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlp.ColumnCount = 1;
			this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp.Controls.Add(this.itemsTlp, 0, 0);
			this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp.Location = new System.Drawing.Point(3, 16);
			this.tlp.MinimumSize = new System.Drawing.Size(0, 20);
			this.tlp.Name = "tlp";
			this.tlp.RowCount = 2;
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp.Size = new System.Drawing.Size(73, 103);
			this.tlp.TabIndex = 4;
			this.tlp.MouseLeave += new System.EventHandler(this.TlpMouseLeave);
			this.tlp.Paint += new System.Windows.Forms.PaintEventHandler(this.TlpPaint);
			this.tlp.Enter += new System.EventHandler(this.TlpEnter);
			this.tlp.MouseHover += new System.EventHandler(this.TlpMouseHover);
			// 
			// itemsTlp
			// 
			this.itemsTlp.AutoSize = true;
			this.itemsTlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.itemsTlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.itemsTlp.ColumnCount = 1;
			this.itemsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.itemsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.itemsTlp.Location = new System.Drawing.Point(4, 4);
			this.itemsTlp.Name = "itemsTlp";
			this.itemsTlp.RowCount = 2;
			this.itemsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.itemsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.itemsTlp.Size = new System.Drawing.Size(2, 3);
			this.itemsTlp.TabIndex = 10;
			this.itemsTlp.MouseLeave += new System.EventHandler(this.ItemsTlpMouseLeave);
			this.itemsTlp.MouseHover += new System.EventHandler(this.ItemsTlpMouseHover);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(40, 3);
			this.button1.MinimumSize = new System.Drawing.Size(30, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 30);
			this.button1.TabIndex = 11;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// gb
			// 
			this.gb.AutoSize = true;
			this.gb.Controls.Add(this.controlsTlp);
			this.gb.Controls.Add(this.tlp);
			this.gb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.gb.Location = new System.Drawing.Point(3, 3);
			this.gb.MinimumSize = new System.Drawing.Size(0, 30);
			this.gb.Name = "gb";
			this.gb.Size = new System.Drawing.Size(79, 122);
			this.gb.TabIndex = 5;
			this.gb.TabStop = false;
			this.gb.Leave += new System.EventHandler(this.GbLeave);
			this.gb.Enter += new System.EventHandler(this.GbEnter);
			this.gb.MouseHover += new System.EventHandler(this.GbMouseHover);
			// 
			// controlsTlp
			// 
			this.controlsTlp.AutoSize = true;
			this.controlsTlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.controlsTlp.ColumnCount = 2;
			this.controlsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.05479F));
			this.controlsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.94521F));
			this.controlsTlp.Controls.Add(this.button1, 1, 0);
			this.controlsTlp.Controls.Add(this.addBtn, 0, 0);
			this.controlsTlp.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.controlsTlp.Location = new System.Drawing.Point(3, 83);
			this.controlsTlp.Name = "controlsTlp";
			this.controlsTlp.RowCount = 1;
			this.controlsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.06061F));
			this.controlsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.controlsTlp.Size = new System.Drawing.Size(73, 36);
			this.controlsTlp.TabIndex = 13;
			this.controlsTlp.Visible = false;
			// 
			// addBtn
			// 
			this.addBtn.AutoSize = true;
			this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
			this.addBtn.Location = new System.Drawing.Point(3, 3);
			this.addBtn.MinimumSize = new System.Drawing.Size(30, 30);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(30, 30);
			this.addBtn.TabIndex = 9;
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.AddBtnClick);
			// 
			// tm
			// 
			this.tm.Tick += new System.EventHandler(this.TmTick);
			// 
			// ListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.gb);
			this.Name = "ListView";
			this.Size = new System.Drawing.Size(132, 211);
			this.Load += new System.EventHandler(this.ListViewLoad);
			this.Click += new System.EventHandler(this.ListViewClick);
			this.tlp.ResumeLayout(false);
			this.tlp.PerformLayout();
			this.gb.ResumeLayout(false);
			this.gb.PerformLayout();
			this.controlsTlp.ResumeLayout(false);
			this.controlsTlp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TableLayoutPanel controlsTlp;
		private System.Windows.Forms.Timer tm;
		private System.Windows.Forms.GroupBox gb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel itemsTlp;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.TableLayoutPanel tlp;
	}
}
