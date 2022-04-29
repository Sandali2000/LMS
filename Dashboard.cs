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
    public partial class Dashboard : Form
    {
        private bool iscollapsed;
        public Dashboard()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Exit?", "conform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               Application.Exit();

            }
            
        }

        private void btnbook1_Click(object sender, EventArgs e)
        {
            viwe_book vb = new viwe_book();
            vb.Show();

        }

        private void btnbook2_Click(object sender, EventArgs e)
        {
            
            addbook abs = new addbook();
            abs.Show();

        }

        private void btnstu_Click(object sender, EventArgs e)
        {
            student xy = new student();
            xy.Show();
            
        }

        private void buttonst2_Click(object sender, EventArgs e)
        {
            Student_viwe st = new Student_viwe();
            st.Show();
           
        }

        private void btniss_Click(object sender, EventArgs e)
        {
            issubook ib = new issubook();
            ib.Show();
        }

        private void btnretun_Click(object sender, EventArgs e)
        {
            returnbook rb = new returnbook();
            rb.Show();
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollapsed)
            {
                panelMenu.Height += 10;
                if (panelMenu.Size == panelMenu.MaximumSize)
                {
                    timer1.Stop();
                    iscollapsed = false;
                }
            }
            else
            {
                panelMenu.Height -= 10;
                if (panelMenu.Size == panelMenu.MinimumSize)
                {
                    timer1.Stop();
                    iscollapsed = true;
                }
            }
        }

        private void subpanle2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from Student ", con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            labelstdent.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from  add_book", con);
            DataTable dt1 = new DataTable();
            sda2.Fill(dt1);
            label2.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from issuebook where book_return_date is null ", con);
            DataTable dt2 = new DataTable();
            sda3.Fill(dt2);
            label4.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from issuebook where book_return_date is not null ", con);
            DataTable dt3 = new DataTable();
            sda4.Fill(dt3);
            label6.Text = dt3.Rows[0][0].ToString();

            con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CompleteDetails bd = new CompleteDetails();
            bd.Show();
        }
    }
}
