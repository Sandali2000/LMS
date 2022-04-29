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
    public partial class issubook : Form
    {
        public issubook()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void issubook_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select books_name from add_book", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetSqlString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        int count;
        private void btssearch_Click(object sender, EventArgs e)
        {
            if (txtenroll.Text != "")
            {
                string eid = txtenroll.Text;
                
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                
                cmd.CommandText = "select * from Student where enrollment_no='" + eid + "'";

                SqlDataAdapter dA = new SqlDataAdapter(cmd);
                DataSet dS = new DataSet();
                dA.Fill(dS);


                // --------------------------------------------------------------------------------
                cmd.CommandText = "select count(std_enroll) from issuebook  where std_enroll='" + eid + "' and book_return_date is null";

                SqlDataAdapter dA1 = new SqlDataAdapter(cmd);
                DataSet dS1 = new DataSet();
                dA.Fill(dS1);
                count = int.Parse(dS1.Tables[0].Rows[0][0].ToString());


                //------------------------------------------------------------------------------


                if (dS.Tables[0].Rows.Count != 0)
                {
                    txtname.Text = dS.Tables[0].Rows[0][1].ToString();
                    txtDep.Text= dS.Tables[0].Rows[0][3].ToString();
                    txtsem.Text= dS.Tables[0].Rows[0][4].ToString();
                    txtscon.Text= dS.Tables[0].Rows[0][5].ToString();
                    txtsmail.Text= dS.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    txtname.Clear();
                    txtDep.Clear();
                    txtsem.Clear();
                    txtscon.Clear();
                    txtsmail.Clear();
                    MessageBox.Show("Invalid Enrollement No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btissue_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    string enroll = txtenroll.Text;
                    string aname = txtname.Text;
                    string sdep = txtDep.Text;
                    string sem = txtsem.Text;
                    Int64 contact = Int64.Parse(txtscon.Text);
                    string email = txtsmail.Text;
                    string bookname = comboBox1.Text;
                    string bookissue = dateTimePicker1.Text;

                    

                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;


                    cmd.CommandText = "insert into issuebook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values('" + enroll + "', '" + aname + "','" + sdep + "','" + sem + "', " + contact + ", '" + email + "', '" + bookname + "', '" + bookissue + "')";

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book. OR Maximum number of book has been ISSUED", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


            }

            else
            {
                MessageBox.Show("Enter Valid Enrollement No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtenroll_TextChanged(object sender, EventArgs e)
        {
            if (txtenroll.Text == "")
            {
                txtname.Clear();
                txtDep.Clear();
                txtsem.Clear();
                txtscon.Clear();
                txtsmail.Clear();
            }
        }

        private void btre_Click(object sender, EventArgs e)
        {
            txtenroll.Clear();
        }

        private void ntnex_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
