namespace RJ_Production
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SignIn_Btn = new System.Windows.Forms.Button();
            this.SignIn_txtBox = new System.Windows.Forms.TextBox();
            this.Password_txtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(156, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(212, 174);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "RJ Production pk";
            // 
            // UserImg
            // 
            this.UserImg.Image = ((System.Drawing.Image)(resources.GetObject("UserImg.Image")));
            this.UserImg.Location = new System.Drawing.Point(116, 261);
            this.UserImg.Name = "UserImg";
            this.UserImg.Size = new System.Drawing.Size(43, 36);
            this.UserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImg.TabIndex = 2;
            this.UserImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(142, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(142, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(116, 329);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // SignIn_Btn
            // 
            this.SignIn_Btn.BackColor = System.Drawing.Color.Blue;
            this.SignIn_Btn.FlatAppearance.BorderSize = 0;
            this.SignIn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn_Btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Btn.ForeColor = System.Drawing.Color.White;
            this.SignIn_Btn.Location = new System.Drawing.Point(142, 414);
            this.SignIn_Btn.Name = "SignIn_Btn";
            this.SignIn_Btn.Size = new System.Drawing.Size(236, 37);
            this.SignIn_Btn.TabIndex = 6;
            this.SignIn_Btn.Text = "SignIn";
            this.SignIn_Btn.UseVisualStyleBackColor = false;
            this.SignIn_Btn.Click += new System.EventHandler(this.SignIn_Btn_Click);
            // 
            // SignIn_txtBox
            // 
            this.SignIn_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignIn_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_txtBox.Location = new System.Drawing.Point(166, 261);
            this.SignIn_txtBox.Multiline = true;
            this.SignIn_txtBox.Name = "SignIn_txtBox";
            this.SignIn_txtBox.Size = new System.Drawing.Size(212, 36);
            this.SignIn_txtBox.TabIndex = 8;
            this.SignIn_txtBox.TextChanged += new System.EventHandler(this.SignIn_txtBox_TextChanged);
            // 
            // Password_txtBox
            // 
            this.Password_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txtBox.Location = new System.Drawing.Point(166, 329);
            this.Password_txtBox.Multiline = true;
            this.Password_txtBox.Name = "Password_txtBox";
            this.Password_txtBox.Size = new System.Drawing.Size(212, 36);
            this.Password_txtBox.TabIndex = 9;
            this.Password_txtBox.TextChanged += new System.EventHandler(this.SignOut_txtBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(227, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password_txtBox);
            this.Controls.Add(this.SignIn_txtBox);
            this.Controls.Add(this.SignIn_Btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox UserImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SignIn_Btn;
        private System.Windows.Forms.TextBox SignIn_txtBox;
        private System.Windows.Forms.TextBox Password_txtBox;
        private System.Windows.Forms.Button button1;
    }
}

