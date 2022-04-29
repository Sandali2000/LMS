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
    public partial class CompleteDetails : Form
    {
        public CompleteDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");

        private void CompleteDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issuebook where book_return_date is null ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
           

            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "select * from issuebook where book_return_date is not null ";
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dS = new DataSet();
            dA.Fill(dS);
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView2.DataSource = dS.Tables[0];
        }
    }
}
