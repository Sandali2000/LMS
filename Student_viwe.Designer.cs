
namespace WindowsFormsApp2
{
    partial class Student_viwe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnfrsh = new System.Windows.Forms.Button();
            this.txtserch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtdepart = new System.Windows.Forms.TextBox();
            this.txtsem = new System.Windows.Forms.TextBox();
            this.txtcontac = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.btncan = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 181);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(634, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 36);
            this.label9.TabIndex = 6;
            this.label9.Text = "Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "View";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._5bf0a3e0601d35349c5451fa52138ea6;
            this.pictureBox1.Location = new System.Drawing.Point(389, -49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnfrsh
            // 
            this.btnfrsh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfrsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrsh.Location = new System.Drawing.Point(682, 204);
            this.btnfrsh.Name = "btnfrsh";
            this.btnfrsh.Size = new System.Drawing.Size(125, 39);
            this.btnfrsh.TabIndex = 8;
            this.btnfrsh.Text = "Refresh";
            this.btnfrsh.UseVisualStyleBackColor = true;
            this.btnfrsh.Click += new System.EventHandler(this.btnfrsh_Click);
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(422, 211);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(232, 22);
            this.txtserch.TabIndex = 7;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enrollment No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 324);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.txtno);
            this.panel2.Controls.Add(this.txtdepart);
            this.panel2.Controls.Add(this.txtsem);
            this.panel2.Controls.Add(this.txtcontac);
            this.panel2.Controls.Add(this.txtmail);
            this.panel2.Controls.Add(this.txtsname);
            this.panel2.Controls.Add(this.btncan);
            this.panel2.Controls.Add(this.btndel);
            this.panel2.Controls.Add(this.btnup);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 609);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 370);
            this.panel2.TabIndex = 9;
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(244, 131);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(258, 27);
            this.txtno.TabIndex = 14;
            // 
            // txtdepart
            // 
            this.txtdepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepart.Location = new System.Drawing.Point(244, 198);
            this.txtdepart.Name = "txtdepart";
            this.txtdepart.Size = new System.Drawing.Size(258, 27);
            this.txtdepart.TabIndex = 13;
            // 
            // txtsem
            // 
            this.txtsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsem.Location = new System.Drawing.Point(759, 67);
            this.txtsem.Name = "txtsem";
            this.txtsem.Size = new System.Drawing.Size(299, 24);
            this.txtsem.TabIndex = 12;
            // 
            // txtcontac
            // 
            this.txtcontac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontac.Location = new System.Drawing.Point(759, 139);
            this.txtcontac.Name = "txtcontac";
            this.txtcontac.Size = new System.Drawing.Size(299, 24);
            this.txtcontac.TabIndex = 11;
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(759, 209);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(299, 24);
            this.txtmail.TabIndex = 10;
            // 
            // txtsname
            // 
            this.txtsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsname.Location = new System.Drawing.Point(244, 63);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(258, 27);
            this.txtsname.TabIndex = 9;
            // 
            // btncan
            // 
            this.btncan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(718, 283);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(103, 39);
            this.btncan.TabIndex = 8;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btndel
            // 
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(568, 283);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(114, 39);
            this.btndel.TabIndex = 7;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnup
            // 
            this.btnup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Location = new System.Drawing.Point(427, 283);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(114, 39);
            this.btnup.TabIndex = 6;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(560, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Student Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Student Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Student Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enrollment No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Name";
            // 
            // Student_viwe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1125, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnfrsh);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Student_viwe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_view";
            this.Load += new System.EventHandler(this.Student_viwe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnfrsh;
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtdepart;
        private System.Windows.Forms.TextBox txtsem;
        private System.Windows.Forms.TextBox txtcontac;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnup;
    }
}