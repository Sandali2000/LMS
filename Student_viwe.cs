using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Student_viwe : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");
        public Student_viwe()
        {
            InitializeComponent();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Student_viwe_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student ";
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dS = new DataSet();
            dA.Fill(dS);
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView1.DataSource = dS.Tables[0];
        }
        int id;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where id=" + id + "";
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dS = new DataSet();
            dA.Fill(dS);
            cmd.ExecuteNonQuery();
            con.Close();

            rowid = Int64.Parse(dS.Tables[0].Rows[0][0].ToString());

            txtsname.Text = dS.Tables[0].Rows[0][1].ToString();
            txtno.Text = dS.Tables[0].Rows[0][2].ToString();
            txtdepart.Text = dS.Tables[0].Rows[0][3].ToString();
            txtsem.Text = dS.Tables[0].Rows[0][4].ToString();
            txtcontac.Text = dS.Tables[0].Rows[0][5].ToString();
            txtmail.Text = dS.Tables[0].Rows[0][6].ToString();
           
        }

        private void btnup_Click(object sender, EventArgs e)
        {

        }

        private void txtserch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtserch.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("C:/source/repos/WindowsFormsApp2/WindowsFormsApp2/Resources/search-gif-image-7.gif");
                pictureBox1.Image = image;

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Student where enrollment_no LIKE '" + txtserch.Text + "%' ";
                SqlDataAdapter dA = new SqlDataAdapter(cmd);
                DataSet dS = new DataSet();
                dA.Fill(dS);
                cmd.ExecuteNonQuery();
                con.Close();

                dataGridView1.DataSource = dS.Tables[0];

            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("C:/source/repos/WindowsFormsApp2/WindowsFormsApp2/Resources/books.gif");
                pictureBox1.Image = image;

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Student ";
                SqlDataAdapter dA = new SqlDataAdapter(cmd);
                DataSet dS = new DataSet();
                dA.Fill(dS);
                cmd.ExecuteNonQuery();
                con.Close();

                dataGridView1.DataSource = dS.Tables[0];
            }

        }

      

        private void btnfrsh_Click(object sender, EventArgs e)
        {
            Student_viwe_Load(this, null);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                string sname = txtsname.Text;
                string num = txtno.Text;
                string dep = txtdepart.Text;
                string sem = txtsem.Text;
                Int64 contact = Int64.Parse(txtcontac.Text);
                string mail = txtmail.Text;

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Student where id=" + rowid + "";
                SqlDataAdapter dA = new SqlDataAdapter(cmd);
                DataSet dS = new DataSet();
                dA.Fill(dS);
                cmd.ExecuteNonQuery();
                con.Close();

                Student_viwe_Load(this, null);
            }
        }

        private void btncan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsave Dta Will Be Lost ", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnup_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Update. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string sname = txtsname.Text;
                string num = txtno.Text;
                string dep = txtdepart.Text;
                string sem = txtsem.Text;
                Int64 contact = Int64.Parse(txtcontac.Text);
                string mail = txtmail.Text;

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Student set student_name='" + sname + "',enrollment_no='" + num + "',department='" + dep + "',semester='" + sem + "',contact='" + contact + "',email='" + mail + "' where id=" + rowid + "";
                SqlDataAdapter dA = new SqlDataAdapter(cmd);
                DataSet dS = new DataSet();
                dA.Fill(dS);
                cmd.ExecuteNonQuery();
                con.Close();

                Student_viwe_Load(this, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
