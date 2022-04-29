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
    public partial class singup : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");
        public singup()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void btnlogin1_Click(object sender, EventArgs e)
        {
            if (txtfname.Text != "" && txtlname.Text != "" && txtuname.Text != "" && txtpassword.Text != "" )
            {

                string name = txtfname.Text;
                string no = txtlname.Text;
                string dep = txtuname.Text;
                string sem = utils.hashpassword( txtpassword.Text);

                
                

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into library_person(First_name,Last_name,User_name,Password) values ('" + name + "','" + no + "','" + dep + "','" + sem + "')";
               

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void singup_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
