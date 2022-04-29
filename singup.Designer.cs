
namespace WindowsFormsApp2
{
    partial class singup
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnREG = new System.Windows.Forms.Button();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlogin1 = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.Location = new System.Drawing.Point(461, 7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(38, 42);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnREG
            // 
            this.btnREG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnREG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREG.ForeColor = System.Drawing.Color.White;
            this.btnREG.Location = new System.Drawing.Point(247, 1);
            this.btnREG.Name = "btnREG";
            this.btnREG.Size = new System.Drawing.Size(259, 57);
            this.btnREG.TabIndex = 17;
            this.btnREG.Text = "Register";
            this.btnREG.UseVisualStyleBackColor = true;
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGIN.ForeColor = System.Drawing.Color.White;
            this.btnLOGIN.Location = new System.Drawing.Point(-1, 1);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(250, 57);
            this.btnLOGIN.TabIndex = 16;
            this.btnLOGIN.Text = "Log In";
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Last Name";
            // 
            // btnlogin1
            // 
            this.btnlogin1.BackColor = System.Drawing.Color.Cyan;
            this.btnlogin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin1.Location = new System.Drawing.Point(53, 474);
            this.btnlogin1.Name = "btnlogin1";
            this.btnlogin1.Size = new System.Drawing.Size(420, 64);
            this.btnlogin1.TabIndex = 23;
            this.btnlogin1.Text = "Register";
            this.btnlogin1.UseVisualStyleBackColor = false;
            this.btnlogin1.Click += new System.EventHandler(this.btnlogin1_Click);
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(216, 165);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(257, 29);
            this.txtfname.TabIndex = 24;
            // 
            // txtuname
            // 
            this.txtuname.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(216, 293);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(257, 29);
            this.txtuname.TabIndex = 25;
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(216, 228);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(257, 29);
            this.txtlname.TabIndex = 26;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(216, 356);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(257, 29);
            this.txtpassword.TabIndex = 27;
            this.txtpassword.Tag = "";
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(53, 544);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(420, 64);
            this.btnexit.TabIndex = 28;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // singup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(511, 658);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.btnlogin1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnREG);
            this.Controls.Add(this.btnLOGIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "singup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "singup";
            this.Load += new System.EventHandler(this.singup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button btnREG;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlogin1;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnexit;
    }
}