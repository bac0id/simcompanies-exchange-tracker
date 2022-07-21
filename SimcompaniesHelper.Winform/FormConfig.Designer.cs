namespace SimcompaniesHelper.Winform {
	partial class FormConfig {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.tbFollowIds = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbAutuRefreshInterval = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ckbAtutoRefresh = new System.Windows.Forms.CheckBox();
			this.ckbTopMost = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.32765F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.67235F));
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.tbFollowIds, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnOK, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tbAutuRefreshInterval, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ckbAtutoRefresh, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.ckbTopMost, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.911785F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.911785F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.911785F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.47071F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.79393F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 302);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(108, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Follow Id";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbFollowIds
			// 
			this.tbFollowIds.AcceptsReturn = true;
			this.tbFollowIds.AllowDrop = true;
			this.tbFollowIds.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbFollowIds.Location = new System.Drawing.Point(175, 90);
			this.tbFollowIds.Multiline = true;
			this.tbFollowIds.Name = "tbFollowIds";
			this.tbFollowIds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbFollowIds.Size = new System.Drawing.Size(82, 173);
			this.tbFollowIds.TabIndex = 4;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(175, 269);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(82, 30);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Auto Refresh Interval (ms)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbAutuRefreshInterval
			// 
			this.tbAutuRefreshInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tbAutuRefreshInterval.Location = new System.Drawing.Point(189, 61);
			this.tbAutuRefreshInterval.Name = "tbAutuRefreshInterval";
			this.tbAutuRefreshInterval.Size = new System.Drawing.Size(54, 23);
			this.tbAutuRefreshInterval.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(86, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Auto Refresh";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(104, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Top Most";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ckbAtutoRefresh
			// 
			this.ckbAtutoRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ckbAtutoRefresh.AutoSize = true;
			this.ckbAtutoRefresh.Location = new System.Drawing.Point(208, 36);
			this.ckbAtutoRefresh.Name = "ckbAtutoRefresh";
			this.ckbAtutoRefresh.Size = new System.Drawing.Size(15, 14);
			this.ckbAtutoRefresh.TabIndex = 2;
			this.ckbAtutoRefresh.UseVisualStyleBackColor = true;
			// 
			// ckbTopMost
			// 
			this.ckbTopMost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ckbTopMost.AutoSize = true;
			this.ckbTopMost.Location = new System.Drawing.Point(208, 7);
			this.ckbTopMost.Name = "ckbTopMost";
			this.ckbTopMost.Size = new System.Drawing.Size(15, 14);
			this.ckbTopMost.TabIndex = 1;
			this.ckbTopMost.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(45, 269);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 30);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(200, 100);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(4, 4);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new System.Drawing.Size(58, 112);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new System.Drawing.Point(73, 0);
			this.labelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
			this.labelProductName.MaximumSize = new System.Drawing.Size(0, 22);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(204, 22);
			this.labelProductName.TabIndex = 19;
			this.labelProductName.Text = "产品名称";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormConfig
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(280, 326);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConfig";
			this.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Config";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnOK;
		private Label label4;
		private TextBox tbFollowIds;
		private TableLayoutPanel tableLayoutPanel;
		private PictureBox logoPictureBox;
		private Label labelProductName;
		private CheckBox ckbTopMost;
		private CheckBox ckbAtutoRefresh;
		private TextBox tbAutuRefreshInterval;
		private Button btnCancel;
	}
}