
namespace WindowsFormsApp2
{
    partial class addbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addbook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeladd = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bbtnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtqunti = new System.Windows.Forms.TextBox();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.txtaname = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.labeladd);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 124);
            this.panel1.TabIndex = 1;
            // 
            // labeladd
            // 
            this.labeladd.AutoSize = true;
            this.labeladd.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labeladd.Location = new System.Drawing.Point(464, 39);
            this.labeladd.Name = "labeladd";
            this.labeladd.Size = new System.Drawing.Size(127, 35);
            this.labeladd.TabIndex = 1;
            this.labeladd.Text = "Add Book";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(278, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.bbtnclear);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.txtqunti);
            this.panel2.Controls.Add(this.txtpro);
            this.panel2.Controls.Add(this.txtaname);
            this.panel2.Controls.Add(this.txtbookname);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lable4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(329, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 467);
            this.panel2.TabIndex = 2;
            // 
            // bbtnclear
            // 
            this.bbtnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bbtnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnclear.Location = new System.Drawing.Point(412, 371);
            this.bbtnclear.Name = "bbtnclear";
            this.bbtnclear.Size = new System.Drawing.Size(107, 37);
            this.bbtnclear.TabIndex = 13;
            this.bbtnclear.Text = "Cancel";
            this.bbtnclear.UseVisualStyleBackColor = true;
            this.bbtnclear.Click += new System.EventHandler(this.bbtnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(253, 371);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(124, 37);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(273, 272);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(344, 28);
            this.txtprice.TabIndex = 10;
            // 
            // txtqunti
            // 
            this.txtqunti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqunti.Location = new System.Drawing.Point(273, 324);
            this.txtqunti.Name = "txtqunti";
            this.txtqunti.Size = new System.Drawing.Size(344, 28);
            this.txtqunti.TabIndex = 9;
            // 
            // txtpro
            // 
            this.txtpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpro.Location = new System.Drawing.Point(273, 153);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(344, 28);
            this.txtpro.TabIndex = 8;
            // 
            // txtaname
            // 
            this.txtaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaname.Location = new System.Drawing.Point(273, 106);
            this.txtaname.Name = "txtaname";
            this.txtaname.Size = new System.Drawing.Size(344, 28);
            this.txtaname.TabIndex = 7;
            // 
            // txtbookname
            // 
            this.txtbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.Location = new System.Drawing.Point(273, 55);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(344, 28);
            this.txtbookname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Book Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book Quantity";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable4.Location = new System.Drawing.Point(32, 210);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(232, 29);
            this.lable4.TabIndex = 3;
            this.lable4.Text = "Book Purchase Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Publication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Author Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(273, 214);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(344, 28);
            this.txtdate.TabIndex = 14;
            // 
            // addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "addbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addbook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeladd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bbtnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtqunti;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.TextBox txtaname;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtdate;
    }
}