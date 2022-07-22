namespace UI.WinForms {
	partial class frmMain {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNewTheme = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNewPHP = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileProject = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileNewCSS = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.splitBody = new System.Windows.Forms.SplitContainer();
			this.tvProject = new System.Windows.Forms.TreeView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitBody)).BeginInit();
			this.splitBody.Panel1.SuspendLayout();
			this.splitBody.Panel2.SuspendLayout();
			this.splitBody.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.toolStripSeparator1,
            this.mnuFileExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mnuFileNew
			// 
			this.mnuFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileProject,
            this.mnuFileNewTheme,
            this.toolStripSeparator2,
            this.mnuFileNewPHP,
            this.mnuFileNewCSS});
			this.mnuFileNew.Name = "mnuFileNew";
			this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
			this.mnuFileNew.Text = "New";
			// 
			// mnuFileNewTheme
			// 
			this.mnuFileNewTheme.Name = "mnuFileNewTheme";
			this.mnuFileNewTheme.Size = new System.Drawing.Size(180, 22);
			this.mnuFileNewTheme.Text = "Theme";
			// 
			// mnuFileNewPHP
			// 
			this.mnuFileNewPHP.Name = "mnuFileNewPHP";
			this.mnuFileNewPHP.Size = new System.Drawing.Size(180, 22);
			this.mnuFileNewPHP.Text = "PHP";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
			this.mnuFileExit.Text = "Exit";
			// 
			// mnuFileProject
			// 
			this.mnuFileProject.Name = "mnuFileProject";
			this.mnuFileProject.Size = new System.Drawing.Size(180, 22);
			this.mnuFileProject.Text = "Project";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// mnuFileNewCSS
			// 
			this.mnuFileNewCSS.Name = "mnuFileNewCSS";
			this.mnuFileNewCSS.Size = new System.Drawing.Size(180, 22);
			this.mnuFileNewCSS.Text = "CSS";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// splitBody
			// 
			this.splitBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitBody.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitBody.Location = new System.Drawing.Point(0, 49);
			this.splitBody.Name = "splitBody";
			// 
			// splitBody.Panel1
			// 
			this.splitBody.Panel1.Controls.Add(this.tvProject);
			// 
			// splitBody.Panel2
			// 
			this.splitBody.Panel2.Controls.Add(this.tabControl1);
			this.splitBody.Size = new System.Drawing.Size(800, 379);
			this.splitBody.SplitterDistance = 190;
			this.splitBody.TabIndex = 3;
			// 
			// tvProject
			// 
			this.tvProject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvProject.Location = new System.Drawing.Point(0, 0);
			this.tvProject.Name = "tvProject";
			this.tvProject.Size = new System.Drawing.Size(190, 379);
			this.tvProject.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(606, 379);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(598, 353);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(192, 74);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitBody);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitBody.Panel1.ResumeLayout(false);
			this.splitBody.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitBody)).EndInit();
			this.splitBody.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
		private System.Windows.Forms.ToolStripMenuItem mnuFileProject;
		private System.Windows.Forms.ToolStripMenuItem mnuFileNewTheme;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuFileNewPHP;
		private System.Windows.Forms.ToolStripMenuItem mnuFileNewCSS;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.SplitContainer splitBody;
		private System.Windows.Forms.TreeView tvProject;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
	}
}

