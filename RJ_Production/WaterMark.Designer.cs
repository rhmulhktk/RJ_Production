namespace RJ_Production
{
    partial class WaterMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterMark));
            this.panelImage = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnWatermark = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.titleLogo = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Developer = new System.Windows.Forms.LinkLabel();
            this.Develop = new System.Windows.Forms.Label();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.Develop);
            this.panelImage.Controls.Add(this.Developer);
            this.panelImage.Controls.Add(this.Title);
            this.panelImage.Controls.Add(this.titleLogo);
            this.panelImage.Controls.Add(this.logoBox);
            this.panelImage.Controls.Add(this.lblStatus);
            this.panelImage.Controls.Add(this.btnWatermark);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(800, 450);
            this.panelImage.TabIndex = 0;
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(300, 149);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(191, 146);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 2;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(370, 360);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Message";
            // 
            // btnWatermark
            // 
            this.btnWatermark.Location = new System.Drawing.Point(360, 314);
            this.btnWatermark.Name = "btnWatermark";
            this.btnWatermark.Size = new System.Drawing.Size(75, 23);
            this.btnWatermark.TabIndex = 0;
            this.btnWatermark.Text = "Upload";
            this.btnWatermark.UseVisualStyleBackColor = true;
            this.btnWatermark.Click += new System.EventHandler(this.btnWatermark_Click);
            // 
            // titleLogo
            // 
            this.titleLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titleLogo.Image = ((System.Drawing.Image)(resources.GetObject("titleLogo.Image")));
            this.titleLogo.Location = new System.Drawing.Point(300, 75);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(191, 59);
            this.titleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleLogo.TabIndex = 3;
            this.titleLogo.TabStop = false;
            this.titleLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(180, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(428, 63);
            this.Title.TabIndex = 4;
            this.Title.Text = "RJ Production pk";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Location = new System.Drawing.Point(364, 414);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(114, 13);
            this.Developer.TabIndex = 5;
            this.Developer.TabStop = true;
            this.Developer.Text = "Raheem Ullah Khattak";
            this.Developer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Developer_LinkClicked);
            // 
            // Develop
            // 
            this.Develop.AutoSize = true;
            this.Develop.Location = new System.Drawing.Point(297, 414);
            this.Develop.Name = "Develop";
            this.Develop.Size = new System.Drawing.Size(61, 13);
            this.Develop.TabIndex = 6;
            this.Develop.Text = "Develop by";
            // 
            // WaterMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaterMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RJ Production 0349-8882108";
            this.Load += new System.EventHandler(this.WaterMark_Load);
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnWatermark;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox titleLogo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Develop;
        private System.Windows.Forms.LinkLabel Developer;
    }
}