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
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            

            cmd.CommandText = "select * from issuebook where std_enroll='" + txtEnroll.Text + "' and book_return_date is null";
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dS = new DataSet();
            dA.Fill(dS);
          

            if (dS.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = dS.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnbook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnroll.Clear();
        }

        string bname;
        string bdate;
        Int64 rowid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            tbook.Text = bname;
            tidate.Text = bdate;
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update issuebook set book_return_date='" + dateTimePicker1.Text + "' where std_enroll='" + txtEnroll.Text + "' and id="+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Succesful.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            returnbook_Load(this, null);
        }

        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnroll.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtEnroll.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
