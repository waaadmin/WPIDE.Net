namespace UI.WinForms {
	partial class frmNew {

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( ) {
			this.splitNew = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.splitNew)).BeginInit();
			this.splitNew.Panel2.SuspendLayout();
			this.splitNew.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitNew
			// 
			this.splitNew.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitNew.Location = new System.Drawing.Point(0, 0);
			this.splitNew.Name = "splitNew";
			this.splitNew.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitNew.Panel2
			// 
			this.splitNew.Panel2.Controls.Add(this.panel2);
			this.splitNew.Panel2.Controls.Add(this.panel1);
			this.splitNew.Size = new System.Drawing.Size(800, 450);
			this.splitNew.SplitterDistance = 298;
			this.splitNew.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOrange;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 100);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Red;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 106);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 42);
			this.panel2.TabIndex = 1;
			// 
			// frmNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitNew);
			this.Name = "frmNew";
			this.Text = "frmNew";
			this.splitNew.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitNew)).EndInit();
			this.splitNew.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitNew;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}