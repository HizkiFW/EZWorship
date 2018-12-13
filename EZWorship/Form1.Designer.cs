namespace EZWorship {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.LoadLyricsButton = new System.Windows.Forms.ToolStripButton();
			this.btnClear = new System.Windows.Forms.ToolStripButton();
			this.btnGoLive = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listSongs = new System.Windows.Forms.ListBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listPreview = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listLive = new System.Windows.Forms.ListBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.remoteControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 563);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// labelStatus
			// 
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(39, 17);
			this.labelStatus.Text = "Ready";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadLyricsButton,
            this.btnClear,
            this.btnGoLive});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1080, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// LoadLyricsButton
			// 
			this.LoadLyricsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.LoadLyricsButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadLyricsButton.Image")));
			this.LoadLyricsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.LoadLyricsButton.Name = "LoadLyricsButton";
			this.LoadLyricsButton.Size = new System.Drawing.Size(23, 22);
			this.LoadLyricsButton.Text = "+";
			this.LoadLyricsButton.Click += new System.EventHandler(this.LoadLyricsButton_Click);
			// 
			// btnClear
			// 
			this.btnClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnClear.Checked = true;
			this.btnClear.CheckOnClick = true;
			this.btnClear.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(38, 22);
			this.btnClear.Text = "Clear";
			this.btnClear.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// btnGoLive
			// 
			this.btnGoLive.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnGoLive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnGoLive.Image = ((System.Drawing.Image)(resources.GetObject("btnGoLive.Image")));
			this.btnGoLive.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGoLive.Name = "btnGoLive";
			this.btnGoLive.Size = new System.Drawing.Size(50, 22);
			this.btnGoLive.Text = "Go Live";
			this.btnGoLive.Click += new System.EventHandler(this.btnGoLive_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteControlToolStripMenuItem,
            this.setOutputToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// setOutputToolStripMenuItem
			// 
			this.setOutputToolStripMenuItem.Name = "setOutputToolStripMenuItem";
			this.setOutputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.setOutputToolStripMenuItem.Text = "Set Output";
			this.setOutputToolStripMenuItem.Click += new System.EventHandler(this.setOutputToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1080, 514);
			this.splitContainer1.SplitterDistance = 265;
			this.splitContainer1.TabIndex = 3;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.listSongs);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(265, 514);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Song List";
			// 
			// listSongs
			// 
			this.listSongs.AllowDrop = true;
			this.listSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listSongs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listSongs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.listSongs.FormattingEnabled = true;
			this.listSongs.Location = new System.Drawing.Point(3, 16);
			this.listSongs.Name = "listSongs";
			this.listSongs.Size = new System.Drawing.Size(259, 495);
			this.listSongs.TabIndex = 0;
			this.listSongs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
			this.listSongs.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ListBox_MeasureItem);
			this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
			this.listSongs.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
			this.listSongs.DragOver += new System.Windows.Forms.DragEventHandler(this.ListBox_DragOver);
			this.listSongs.DoubleClick += new System.EventHandler(this.listSongs_DoubleClick);
			this.listSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listSongs_KeyDown);
			this.listSongs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listSongs_MouseDown);
			this.listSongs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listSongs_MouseMove);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer2.Size = new System.Drawing.Size(811, 514);
			this.splitContainer2.SplitterDistance = 376;
			this.splitContainer2.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listPreview);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 514);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Preview";
			// 
			// listPreview
			// 
			this.listPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listPreview.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.listPreview.FormattingEnabled = true;
			this.listPreview.ItemHeight = 26;
			this.listPreview.Location = new System.Drawing.Point(3, 16);
			this.listPreview.Name = "listPreview";
			this.listPreview.Size = new System.Drawing.Size(370, 495);
			this.listPreview.TabIndex = 0;
			this.listPreview.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
			this.listPreview.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ListBox_MeasureItem);
			this.listPreview.DoubleClick += new System.EventHandler(this.listPreview_DoubleClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listLive);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(431, 514);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Live";
			// 
			// listLive
			// 
			this.listLive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listLive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listLive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.listLive.FormattingEnabled = true;
			this.listLive.Location = new System.Drawing.Point(3, 16);
			this.listLive.Name = "listLive";
			this.listLive.Size = new System.Drawing.Size(425, 495);
			this.listLive.TabIndex = 0;
			this.listLive.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
			this.listLive.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ListBox_MeasureItem);
			this.listLive.SelectedIndexChanged += new System.EventHandler(this.listLive_SelectedIndexChanged);
			this.listLive.DoubleClick += new System.EventHandler(this.listLive_DoubleClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
			this.openFileDialog1.Multiselect = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
			// 
			// remoteControlToolStripMenuItem
			// 
			this.remoteControlToolStripMenuItem.Name = "remoteControlToolStripMenuItem";
			this.remoteControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.remoteControlToolStripMenuItem.Text = "Remote Control";
			this.remoteControlToolStripMenuItem.Click += new System.EventHandler(this.remoteControlToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 585);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "EZWorship";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton LoadLyricsButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStripButton btnClear;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listSongs;
		private System.Windows.Forms.ListBox listPreview;
		private System.Windows.Forms.ListBox listLive;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripButton btnGoLive;
		private System.Windows.Forms.ToolStripStatusLabel labelStatus;
		private System.Windows.Forms.ToolStripMenuItem setOutputToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem remoteControlToolStripMenuItem;
	}
}

