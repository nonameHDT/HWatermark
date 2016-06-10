namespace HWatermark
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pboxResult = new System.Windows.Forms.PictureBox();
			this.grboxSingleImage = new System.Windows.Forms.GroupBox();
			this.txtImage = new System.Windows.Forms.TextBox();
			this.txtWatermark = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBrowseImage = new System.Windows.Forms.Button();
			this.btnBrowseWatermark = new System.Windows.Forms.Button();
			this.grboxFolder = new System.Windows.Forms.GroupBox();
			this.txtFolderFolder = new System.Windows.Forms.TextBox();
			this.txtFolderWatermark = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnFolderBrowseFolder = new System.Windows.Forms.Button();
			this.btnFolderBrowseWatermark = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chkSubFolder = new System.Windows.Forms.CheckBox();
			this.rdFolder = new System.Windows.Forms.RadioButton();
			this.rdSingleImage = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rdCenterRight = new System.Windows.Forms.RadioButton();
			this.rdCenterLeft = new System.Windows.Forms.RadioButton();
			this.rdBottomCenter = new System.Windows.Forms.RadioButton();
			this.rdTopCenter = new System.Windows.Forms.RadioButton();
			this.rdBottomRight = new System.Windows.Forms.RadioButton();
			this.rdBottomLeft = new System.Windows.Forms.RadioButton();
			this.rdCenter = new System.Windows.Forms.RadioButton();
			this.rdTopRight = new System.Windows.Forms.RadioButton();
			this.rdTopLeft = new System.Windows.Forms.RadioButton();
			this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.dlgFile = new System.Windows.Forms.OpenFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.processBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.pboxResult)).BeginInit();
			this.grboxSingleImage.SuspendLayout();
			this.grboxFolder.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pboxResult
			// 
			this.pboxResult.Location = new System.Drawing.Point(316, 12);
			this.pboxResult.Name = "pboxResult";
			this.pboxResult.Size = new System.Drawing.Size(673, 504);
			this.pboxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxResult.TabIndex = 0;
			this.pboxResult.TabStop = false;
			// 
			// grboxSingleImage
			// 
			this.grboxSingleImage.Controls.Add(this.txtImage);
			this.grboxSingleImage.Controls.Add(this.txtWatermark);
			this.grboxSingleImage.Controls.Add(this.label2);
			this.grboxSingleImage.Controls.Add(this.label1);
			this.grboxSingleImage.Controls.Add(this.btnBrowseImage);
			this.grboxSingleImage.Controls.Add(this.btnBrowseWatermark);
			this.grboxSingleImage.Location = new System.Drawing.Point(12, 95);
			this.grboxSingleImage.Name = "grboxSingleImage";
			this.grboxSingleImage.Size = new System.Drawing.Size(298, 102);
			this.grboxSingleImage.TabIndex = 3;
			this.grboxSingleImage.TabStop = false;
			this.grboxSingleImage.Text = "Single Image";
			// 
			// txtImage
			// 
			this.txtImage.Location = new System.Drawing.Point(74, 64);
			this.txtImage.Name = "txtImage";
			this.txtImage.Size = new System.Drawing.Size(157, 20);
			this.txtImage.TabIndex = 6;
			// 
			// txtWatermark
			// 
			this.txtWatermark.Location = new System.Drawing.Point(74, 29);
			this.txtWatermark.Name = "txtWatermark";
			this.txtWatermark.Size = new System.Drawing.Size(157, 20);
			this.txtWatermark.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Image:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Watermark:";
			// 
			// btnBrowseImage
			// 
			this.btnBrowseImage.Location = new System.Drawing.Point(237, 62);
			this.btnBrowseImage.Name = "btnBrowseImage";
			this.btnBrowseImage.Size = new System.Drawing.Size(44, 23);
			this.btnBrowseImage.TabIndex = 1;
			this.btnBrowseImage.Text = "...";
			this.btnBrowseImage.UseVisualStyleBackColor = true;
			this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
			// 
			// btnBrowseWatermark
			// 
			this.btnBrowseWatermark.Location = new System.Drawing.Point(237, 27);
			this.btnBrowseWatermark.Name = "btnBrowseWatermark";
			this.btnBrowseWatermark.Size = new System.Drawing.Size(44, 23);
			this.btnBrowseWatermark.TabIndex = 0;
			this.btnBrowseWatermark.Text = "...";
			this.btnBrowseWatermark.UseVisualStyleBackColor = true;
			this.btnBrowseWatermark.Click += new System.EventHandler(this.btnBrowseWatermark_Click);
			// 
			// grboxFolder
			// 
			this.grboxFolder.Controls.Add(this.txtFolderFolder);
			this.grboxFolder.Controls.Add(this.txtFolderWatermark);
			this.grboxFolder.Controls.Add(this.label3);
			this.grboxFolder.Controls.Add(this.label4);
			this.grboxFolder.Controls.Add(this.btnFolderBrowseFolder);
			this.grboxFolder.Controls.Add(this.btnFolderBrowseWatermark);
			this.grboxFolder.Enabled = false;
			this.grboxFolder.Location = new System.Drawing.Point(12, 203);
			this.grboxFolder.Name = "grboxFolder";
			this.grboxFolder.Size = new System.Drawing.Size(298, 101);
			this.grboxFolder.TabIndex = 4;
			this.grboxFolder.TabStop = false;
			this.grboxFolder.Text = "Folder";
			// 
			// txtFolderFolder
			// 
			this.txtFolderFolder.Location = new System.Drawing.Point(74, 63);
			this.txtFolderFolder.Name = "txtFolderFolder";
			this.txtFolderFolder.Size = new System.Drawing.Size(157, 20);
			this.txtFolderFolder.TabIndex = 12;
			// 
			// txtFolderWatermark
			// 
			this.txtFolderWatermark.Location = new System.Drawing.Point(74, 28);
			this.txtFolderWatermark.Name = "txtFolderWatermark";
			this.txtFolderWatermark.Size = new System.Drawing.Size(157, 20);
			this.txtFolderWatermark.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Folder:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Watermark:";
			// 
			// btnFolderBrowseFolder
			// 
			this.btnFolderBrowseFolder.Location = new System.Drawing.Point(237, 61);
			this.btnFolderBrowseFolder.Name = "btnFolderBrowseFolder";
			this.btnFolderBrowseFolder.Size = new System.Drawing.Size(44, 23);
			this.btnFolderBrowseFolder.TabIndex = 8;
			this.btnFolderBrowseFolder.Text = "...";
			this.btnFolderBrowseFolder.UseVisualStyleBackColor = true;
			this.btnFolderBrowseFolder.Click += new System.EventHandler(this.btnFolderBrowseFolder_Click);
			// 
			// btnFolderBrowseWatermark
			// 
			this.btnFolderBrowseWatermark.Location = new System.Drawing.Point(237, 26);
			this.btnFolderBrowseWatermark.Name = "btnFolderBrowseWatermark";
			this.btnFolderBrowseWatermark.Size = new System.Drawing.Size(44, 23);
			this.btnFolderBrowseWatermark.TabIndex = 7;
			this.btnFolderBrowseWatermark.Text = "...";
			this.btnFolderBrowseWatermark.UseVisualStyleBackColor = true;
			this.btnFolderBrowseWatermark.Click += new System.EventHandler(this.btnFolderBrowseWatermark_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 405);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(298, 51);
			this.btnStart.TabIndex = 5;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chkSubFolder);
			this.groupBox3.Controls.Add(this.rdFolder);
			this.groupBox3.Controls.Add(this.rdSingleImage);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(298, 77);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Choose Mode";
			// 
			// chkSubFolder
			// 
			this.chkSubFolder.AutoSize = true;
			this.chkSubFolder.Enabled = false;
			this.chkSubFolder.Location = new System.Drawing.Point(154, 43);
			this.chkSubFolder.Name = "chkSubFolder";
			this.chkSubFolder.Size = new System.Drawing.Size(77, 17);
			this.chkSubFolder.TabIndex = 3;
			this.chkSubFolder.Text = "Sub Folder";
			this.chkSubFolder.UseVisualStyleBackColor = true;
			// 
			// rdFolder
			// 
			this.rdFolder.AutoSize = true;
			this.rdFolder.Location = new System.Drawing.Point(9, 42);
			this.rdFolder.Name = "rdFolder";
			this.rdFolder.Size = new System.Drawing.Size(54, 17);
			this.rdFolder.TabIndex = 5;
			this.rdFolder.Text = "Folder";
			this.rdFolder.UseVisualStyleBackColor = true;
			// 
			// rdSingleImage
			// 
			this.rdSingleImage.AutoSize = true;
			this.rdSingleImage.Checked = true;
			this.rdSingleImage.Location = new System.Drawing.Point(9, 19);
			this.rdSingleImage.Name = "rdSingleImage";
			this.rdSingleImage.Size = new System.Drawing.Size(86, 17);
			this.rdSingleImage.TabIndex = 4;
			this.rdSingleImage.TabStop = true;
			this.rdSingleImage.Text = "Single Image";
			this.rdSingleImage.UseVisualStyleBackColor = true;
			this.rdSingleImage.CheckedChanged += new System.EventHandler(this.rdSingleImage_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rdCenterRight);
			this.groupBox4.Controls.Add(this.rdCenterLeft);
			this.groupBox4.Controls.Add(this.rdBottomCenter);
			this.groupBox4.Controls.Add(this.rdTopCenter);
			this.groupBox4.Controls.Add(this.rdBottomRight);
			this.groupBox4.Controls.Add(this.rdBottomLeft);
			this.groupBox4.Controls.Add(this.rdCenter);
			this.groupBox4.Controls.Add(this.rdTopRight);
			this.groupBox4.Controls.Add(this.rdTopLeft);
			this.groupBox4.Location = new System.Drawing.Point(12, 310);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(298, 89);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Position";
			// 
			// rdCenterRight
			// 
			this.rdCenterRight.AutoSize = true;
			this.rdCenterRight.Location = new System.Drawing.Point(235, 42);
			this.rdCenterRight.Name = "rdCenterRight";
			this.rdCenterRight.Size = new System.Drawing.Size(31, 17);
			this.rdCenterRight.TabIndex = 8;
			this.rdCenterRight.Text = "6";
			this.rdCenterRight.UseVisualStyleBackColor = true;
			this.rdCenterRight.Click += new System.EventHandler(this.rdCenterRight_Click);
			// 
			// rdCenterLeft
			// 
			this.rdCenterLeft.AutoSize = true;
			this.rdCenterLeft.Location = new System.Drawing.Point(37, 43);
			this.rdCenterLeft.Name = "rdCenterLeft";
			this.rdCenterLeft.Size = new System.Drawing.Size(31, 17);
			this.rdCenterLeft.TabIndex = 7;
			this.rdCenterLeft.Text = "4";
			this.rdCenterLeft.UseVisualStyleBackColor = true;
			this.rdCenterLeft.Click += new System.EventHandler(this.rdCenterLeft_Click);
			// 
			// rdBottomCenter
			// 
			this.rdBottomCenter.AutoSize = true;
			this.rdBottomCenter.Location = new System.Drawing.Point(137, 66);
			this.rdBottomCenter.Name = "rdBottomCenter";
			this.rdBottomCenter.Size = new System.Drawing.Size(31, 17);
			this.rdBottomCenter.TabIndex = 6;
			this.rdBottomCenter.Text = "8";
			this.rdBottomCenter.UseVisualStyleBackColor = true;
			this.rdBottomCenter.Click += new System.EventHandler(this.rdBottomCenter_Click);
			// 
			// rdTopCenter
			// 
			this.rdTopCenter.AutoSize = true;
			this.rdTopCenter.Location = new System.Drawing.Point(137, 19);
			this.rdTopCenter.Name = "rdTopCenter";
			this.rdTopCenter.Size = new System.Drawing.Size(31, 17);
			this.rdTopCenter.TabIndex = 5;
			this.rdTopCenter.Text = "2";
			this.rdTopCenter.UseVisualStyleBackColor = true;
			this.rdTopCenter.Click += new System.EventHandler(this.rdTopCenter_Click);
			// 
			// rdBottomRight
			// 
			this.rdBottomRight.AutoSize = true;
			this.rdBottomRight.Location = new System.Drawing.Point(235, 66);
			this.rdBottomRight.Name = "rdBottomRight";
			this.rdBottomRight.Size = new System.Drawing.Size(31, 17);
			this.rdBottomRight.TabIndex = 4;
			this.rdBottomRight.Text = "9";
			this.rdBottomRight.UseVisualStyleBackColor = true;
			this.rdBottomRight.Click += new System.EventHandler(this.rdBottomRight_Click);
			// 
			// rdBottomLeft
			// 
			this.rdBottomLeft.AutoSize = true;
			this.rdBottomLeft.Location = new System.Drawing.Point(37, 66);
			this.rdBottomLeft.Name = "rdBottomLeft";
			this.rdBottomLeft.Size = new System.Drawing.Size(31, 17);
			this.rdBottomLeft.TabIndex = 3;
			this.rdBottomLeft.Text = "7";
			this.rdBottomLeft.UseVisualStyleBackColor = true;
			this.rdBottomLeft.Click += new System.EventHandler(this.rdBottomLeft_Click);
			// 
			// rdCenter
			// 
			this.rdCenter.AutoSize = true;
			this.rdCenter.Location = new System.Drawing.Point(137, 43);
			this.rdCenter.Name = "rdCenter";
			this.rdCenter.Size = new System.Drawing.Size(31, 17);
			this.rdCenter.TabIndex = 2;
			this.rdCenter.Text = "5";
			this.rdCenter.UseVisualStyleBackColor = true;
			this.rdCenter.Click += new System.EventHandler(this.rdCenter_Click);
			// 
			// rdTopRight
			// 
			this.rdTopRight.AutoSize = true;
			this.rdTopRight.Location = new System.Drawing.Point(235, 19);
			this.rdTopRight.Name = "rdTopRight";
			this.rdTopRight.Size = new System.Drawing.Size(31, 17);
			this.rdTopRight.TabIndex = 1;
			this.rdTopRight.Text = "3";
			this.rdTopRight.UseVisualStyleBackColor = true;
			this.rdTopRight.Click += new System.EventHandler(this.rdTopRight_Click);
			// 
			// rdTopLeft
			// 
			this.rdTopLeft.AutoSize = true;
			this.rdTopLeft.Checked = true;
			this.rdTopLeft.Location = new System.Drawing.Point(37, 19);
			this.rdTopLeft.Name = "rdTopLeft";
			this.rdTopLeft.Size = new System.Drawing.Size(31, 17);
			this.rdTopLeft.TabIndex = 0;
			this.rdTopLeft.TabStop = true;
			this.rdTopLeft.Text = "1";
			this.rdTopLeft.UseVisualStyleBackColor = true;
			this.rdTopLeft.Click += new System.EventHandler(this.rdTopLeft_Click);
			// 
			// dlgFile
			// 
			this.dlgFile.FileName = "openFileDialog1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.processBar1,
            this.statusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 523);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(998, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
			this.toolStripStatusLabel1.Text = "Processed:";
			// 
			// processBar1
			// 
			this.processBar1.Name = "processBar1";
			this.processBar1.Size = new System.Drawing.Size(800, 16);
			// 
			// statusLabel1
			// 
			this.statusLabel1.Name = "statusLabel1";
			this.statusLabel1.Size = new System.Drawing.Size(36, 17);
			this.statusLabel1.Text = "0/100";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 545);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.grboxFolder);
			this.Controls.Add(this.grboxSingleImage);
			this.Controls.Add(this.pboxResult);
			this.Name = "Form1";
			this.Text = "HWatermark";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pboxResult)).EndInit();
			this.grboxSingleImage.ResumeLayout(false);
			this.grboxSingleImage.PerformLayout();
			this.grboxFolder.ResumeLayout(false);
			this.grboxFolder.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pboxResult;
		private System.Windows.Forms.GroupBox grboxSingleImage;
		private System.Windows.Forms.TextBox txtImage;
		private System.Windows.Forms.TextBox txtWatermark;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBrowseImage;
		private System.Windows.Forms.Button btnBrowseWatermark;
		private System.Windows.Forms.GroupBox grboxFolder;
		private System.Windows.Forms.TextBox txtFolderFolder;
		private System.Windows.Forms.TextBox txtFolderWatermark;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnFolderBrowseFolder;
		private System.Windows.Forms.Button btnFolderBrowseWatermark;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox chkSubFolder;
		private System.Windows.Forms.RadioButton rdFolder;
		private System.Windows.Forms.RadioButton rdSingleImage;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rdBottomRight;
		private System.Windows.Forms.RadioButton rdBottomLeft;
		private System.Windows.Forms.RadioButton rdCenter;
		private System.Windows.Forms.RadioButton rdTopRight;
		private System.Windows.Forms.RadioButton rdTopLeft;
		private System.Windows.Forms.RadioButton rdCenterRight;
		private System.Windows.Forms.RadioButton rdCenterLeft;
		private System.Windows.Forms.RadioButton rdBottomCenter;
		private System.Windows.Forms.RadioButton rdTopCenter;
		private System.Windows.Forms.FolderBrowserDialog dlgFolder;
		private System.Windows.Forms.OpenFileDialog dlgFile;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar processBar1;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
	}
}

