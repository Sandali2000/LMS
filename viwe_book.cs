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
    public partial class viwe_book : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");

        public viwe_book()
        {
            InitializeComponent();
        }

        private void viwe_book_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from add_book ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView1.DataSource = ds.Tables[0];
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
            cmd.CommandText = "select * from add_book where id=" + id + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtN.Text = ds.Tables[0].Rows[0][1].ToString();
            txtA.Text = ds.Tables[0].Rows[0][2].ToString();
            txtP.Text = ds.Tables[0].Rows[0][3].ToString();
            txtD.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPr.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQ.Text = ds.Tables[0].Rows[0][6].ToString();


        }

        private void btncan_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from add_book where books_name LIKE'" + txtsearch.Text + "%' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();
                con.Close();

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from add_book ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();
                con.Close();

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnse_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Update. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                string bname = txtN.Text;
                string boaut = txtA.Text;
                string publi = txtP.Text;
                string date = txtD.Text;
                Int64 price = Int64.Parse(txtPr.Text);
                Int64 qunt = Int64.Parse(txtQ.Text);


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update add_book set books_name='" + bname + "', book_author_name='" + boaut + "', books_pablication='" + publi + "', books_purchase_date='" + date + "', book_price=" + price + ", books_quantity=" + qunt + " where id=" + id + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

            }

        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from add_book where id=" + id + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

            }
        }
    }
}

