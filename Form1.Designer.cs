namespace MyOpenCvProject
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
            this.components = new System.ComponentModel.Container();
            this.btnConvertToAscii = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browserMain = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnConvertToAsciiStructure = new System.Windows.Forms.Button();
            this.webcam = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertToAscii
            // 
            this.btnConvertToAscii.Location = new System.Drawing.Point(586, 71);
            this.btnConvertToAscii.Name = "btnConvertToAscii";
            this.btnConvertToAscii.Size = new System.Drawing.Size(125, 21);
            this.btnConvertToAscii.TabIndex = 3;
            this.btnConvertToAscii.Text = "�ƽ�Ű �ڵ�� ��ȯ";
            this.btnConvertToAscii.UseVisualStyleBackColor = true;
            this.btnConvertToAscii.Click += new System.EventHandler(this.btnConvertToAscii_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(691, 34);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(74, 21);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "ã�ƺ���";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(14, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(671, 21);
            this.txtPath.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browserMain
            // 
            this.browserMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserMain.Location = new System.Drawing.Point(14, 102);
            this.browserMain.MinimumSize = new System.Drawing.Size(23, 18);
            this.browserMain.Name = "browserMain";
            this.browserMain.Size = new System.Drawing.Size(817, 624);
            this.browserMain.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.����ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "����";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveAsToolStripMenuItem.Text = "�ٸ� �̸����� ����";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "������";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ����ToolStripMenuItem
            // 
            this.����ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.������ToolStripMenuItem});
            this.����ToolStripMenuItem.Name = "����ToolStripMenuItem";
            this.����ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.����ToolStripMenuItem.Text = "����";
            // 
            // ������ToolStripMenuItem
            // 
            this.������ToolStripMenuItem.Name = "������ToolStripMenuItem";
            this.������ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.������ToolStripMenuItem.Text = "������";
            this.������ToolStripMenuItem.Click += new System.EventHandler(this.������ToolStripMenuItem_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(14, 58);
            this.trackBar.Maximum = 400;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(250, 45);
            this.trackBar.TabIndex = 9;
            this.trackBar.TickFrequency = 20;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "���� ���� �����Ͽ� ��ȯ ũ�⸦ �����Ҽ� �ֽ��ϴ�.";
            // 
            // btnConvertToAsciiStructure
            // 
            this.btnConvertToAsciiStructure.Location = new System.Drawing.Point(717, 71);
            this.btnConvertToAsciiStructure.Name = "btnConvertToAsciiStructure";
            this.btnConvertToAsciiStructure.Size = new System.Drawing.Size(114, 21);
            this.btnConvertToAsciiStructure.TabIndex = 11;
            this.btnConvertToAsciiStructure.Text = "�ƽ�Ű�ڵ� (����)";
            this.btnConvertToAsciiStructure.UseVisualStyleBackColor = true;
            this.btnConvertToAsciiStructure.Click += new System.EventHandler(this.btnConvertToAsciiStructure_Click);
            // 
            // webcam
            // 
            this.webcam.Location = new System.Drawing.Point(771, 34);
            this.webcam.Name = "webcam";
            this.webcam.Size = new System.Drawing.Size(62, 21);
            this.webcam.TabIndex = 12;
            this.webcam.Text = "��ķ";
            this.webcam.UseVisualStyleBackColor = true;
            this.webcam.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 735);
            this.Controls.Add(this.webcam);
            this.Controls.Add(this.btnConvertToAsciiStructure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.browserMain);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnConvertToAscii);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "�ƽ�Ű�ڵ� ��ȯ��";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
      
        #endregion

        private System.Windows.Forms.Button btnConvertToAscii;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.WebBrowser browserMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.ToolStripMenuItem ����ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ������ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnConvertToAsciiStructure;
        private System.Windows.Forms.Button webcam;
    }
}

