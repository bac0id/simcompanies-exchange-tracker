namespace SimcompaniesHelper.Winform {
	partial class FormMain {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "188",
            "something",
            "123.00",
            "123.01",
            "123.02",
            "123.03",
            "123.04",
            "123.05"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "666"}, -1, System.Drawing.Color.Green, System.Drawing.Color.Empty, null);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.lvPriceListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.timerRefreshExchange = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.inportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripRefreshTime = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelRefreshTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.formsPlot1 = new ScottPlot.FormsPlot();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.menuStrip1.SuspendLayout();
			this.statusStripRefreshTime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvPriceListView
			// 
			this.lvPriceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader4,
            this.columnHeader5});
			this.lvPriceListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPriceListView.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lvPriceListView.FullRowSelect = true;
			this.lvPriceListView.GridLines = true;
			listViewItem1.StateImageIndex = 0;
			this.lvPriceListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lvPriceListView.LabelWrap = false;
			this.lvPriceListView.Location = new System.Drawing.Point(0, 0);
			this.lvPriceListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lvPriceListView.Name = "lvPriceListView";
			this.lvPriceListView.Size = new System.Drawing.Size(543, 326);
			this.lvPriceListView.TabIndex = 0;
			this.lvPriceListView.UseCompatibleStateImageBehavior = false;
			this.lvPriceListView.View = System.Windows.Forms.View.Details;
			this.lvPriceListView.SelectedIndexChanged += new System.EventHandler(this.lvPriceListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			this.columnHeader1.Width = 32;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Now";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Ravg";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Rmin";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Rmax";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Hmin";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Hmax";
			// 
			// timerRefreshExchange
			// 
			this.timerRefreshExchange.Interval = 1000;
			this.timerRefreshExchange.Tick += new System.EventHandler(this.timerRefreshExchange_Tick);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(543, 25);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "Menu";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inportToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 21);
			this.toolStripMenuItem1.Text = "Data";
			// 
			// inportToolStripMenuItem
			// 
			this.inportToolStripMenuItem.Name = "inportToolStripMenuItem";
			this.inportToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.inportToolStripMenuItem.Text = "Load history";
			this.inportToolStripMenuItem.Click += new System.EventHandler(this.inportToolStripMenuItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.exportToolStripMenuItem.Text = "Save history";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(64, 21);
			this.toolStripMenuItem2.Text = "Refresh";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(58, 21);
			this.toolStripMenuItem3.Text = "Config";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem5});
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(47, 21);
			this.toolStripMenuItem4.Text = "Help";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(229, 22);
			this.toolStripMenuItem6.Text = "Column Name Description";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(229, 22);
			this.toolStripMenuItem5.Text = "About";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// statusStripRefreshTime
			// 
			this.statusStripRefreshTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRefreshTime});
			this.statusStripRefreshTime.Location = new System.Drawing.Point(0, 475);
			this.statusStripRefreshTime.Name = "statusStripRefreshTime";
			this.statusStripRefreshTime.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
			this.statusStripRefreshTime.Size = new System.Drawing.Size(543, 22);
			this.statusStripRefreshTime.TabIndex = 7;
			this.statusStripRefreshTime.Text = "statusStrip1";
			// 
			// toolStripStatusLabelRefreshTime
			// 
			this.toolStripStatusLabelRefreshTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.toolStripStatusLabelRefreshTime.Name = "toolStripStatusLabelRefreshTime";
			this.toolStripStatusLabelRefreshTime.Size = new System.Drawing.Size(126, 17);
			this.toolStripStatusLabelRefreshTime.Text = "2022-12-25 22:22:22";
			// 
			// formsPlot1
			// 
			this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formsPlot1.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.formsPlot1.Location = new System.Drawing.Point(0, 0);
			this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.formsPlot1.Name = "formsPlot1";
			this.formsPlot1.Size = new System.Drawing.Size(543, 120);
			this.formsPlot1.TabIndex = 8;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lvPriceListView);
			this.splitContainer1.Panel1MinSize = 0;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.formsPlot1);
			this.splitContainer1.Panel2MinSize = 0;
			this.splitContainer1.Size = new System.Drawing.Size(543, 450);
			this.splitContainer1.SplitterDistance = 326;
			this.splitContainer1.TabIndex = 9;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 497);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStripRefreshTime);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormMain";
			this.Text = "Sim Companies Exchange Tracker";
			this.TopMost = true;
			this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStripRefreshTime.ResumeLayout(false);
			this.statusStripRefreshTime.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListView lvPriceListView;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private System.Windows.Forms.Timer timerRefreshExchange;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripMenuItem inportToolStripMenuItem;
		private ToolStripMenuItem exportToolStripMenuItem;
		private StatusStrip statusStripRefreshTime;
		private ToolStripStatusLabel toolStripStatusLabelRefreshTime;
		private ToolStripMenuItem toolStripMenuItem3;
		private ToolStripMenuItem toolStripMenuItem4;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private ScottPlot.FormsPlot formsPlot1;
		private SplitContainer splitContainer1;
		private ToolStripMenuItem toolStripMenuItem5;
		private ToolStripMenuItem toolStripMenuItem6;
	}
}