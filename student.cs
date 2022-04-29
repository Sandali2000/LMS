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
    public partial class student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");
        public student()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtno.Clear();
            txtdep.Clear();
            txtsem.Clear();
            txtcon.Clear();
            txtmail.Clear();
        }

        private void bbtsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtno.Text != "" && txtdep.Text != "" && txtsem.Text != "" && txtcon.Text != "" && txtmail.Text != "")
            {

                string name = txtname.Text;
                string no = txtno.Text;
                string dep = txtdep.Text;
                string sem = txtsem.Text;
                Int64 mobil = Int64.Parse(txtcon.Text);
                string mail = txtmail.Text;

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Student(student_name,enrollment_no,department,semester,contact,email) values ('" + name + "','" + no + "','" + dep + "','" + sem + "'," + mobil + ",'" + mail + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
