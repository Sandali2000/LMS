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
    public partial class Form1 : Form
        
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Clear();
                txtpass.PasswordChar ='*';
            }
        }

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtusername.Text == "Username") ;
            {
                txtusername.Clear();
            }
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void ins_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/login/");
        }
         private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "select * from library_person where User_name='" + txtusername.Text + "'and Password=@Password";
            
            cmd.Parameters.AddWithValue("@Password",utils.hashpassword( txtpass.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("Wrong Username or Password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Dashboard ds = new Dashboard();

                ds.Show();
            }
       


        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            singup su = new singup();
            su.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
