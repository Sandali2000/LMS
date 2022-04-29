
namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.youtube = new System.Windows.Forms.PictureBox();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.ins = new System.Windows.Forms.PictureBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ins)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Author_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(178, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(458, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(41, 348);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(41, 400);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // youtube
            // 
            this.youtube.Image = ((System.Drawing.Image)(resources.GetObject("youtube.Image")));
            this.youtube.Location = new System.Drawing.Point(303, 656);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(37, 37);
            this.youtube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.youtube.TabIndex = 4;
            this.youtube.TabStop = false;
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            // 
            // facebook
            // 
            this.facebook.ErrorImage = ((System.Drawing.Image)(resources.GetObject("facebook.ErrorImage")));
            this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
            this.facebook.Location = new System.Drawing.Point(209, 656);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(50, 37);
            this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebook.TabIndex = 5;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // ins
            // 
            this.ins.Image = ((System.Drawing.Image)(resources.GetObject("ins.Image")));
            this.ins.Location = new System.Drawing.Point(131, 656);
            this.ins.Name = "ins";
            this.ins.Size = new System.Drawing.Size(32, 37);
            this.ins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ins.TabIndex = 6;
            this.ins.TabStop = false;
            this.ins.Click += new System.EventHandler(this.ins_Click);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.White;
            this.txtusername.Location = new System.Drawing.Point(145, 348);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(335, 27);
            this.txtusername.TabIndex = 7;
            this.txtusername.Text = "Username";
            this.txtusername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtusername_MouseClick);
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(145, 411);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(303, 27);
            this.txtpass.TabIndex = 8;
            this.txtpass.Tag = "";
            this.txtpass.Text = "Password";
            this.txtpass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtpass_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(145, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 4);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(145, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 4);
            this.panel2.TabIndex = 10;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Cyan;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(28, 485);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(420, 64);
            this.btnlogin.TabIndex = 11;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnlog
            // 
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.White;
            this.btnlog.Location = new System.Drawing.Point(3, 6);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(245, 57);
            this.btnlog.TabIndex = 13;
            this.btnlog.Text = "Log In";
            this.btnlog.UseVisualStyleBackColor = true;
            // 
            // btnreg
            // 
            this.btnreg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.ForeColor = System.Drawing.Color.White;
            this.btnreg.Location = new System.Drawing.Point(247, 6);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(251, 57);
            this.btnreg.TabIndex = 14;
            this.btnreg.Text = "Registur";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(28, 555);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(420, 64);
            this.btnexit.TabIndex = 29;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(500, 705);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.ins);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.youtube);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox youtube;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.PictureBox ins;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnexit;
    }
}

