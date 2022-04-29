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
    public partial class addbook : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\login_library_system.mdf;Integrated Security=True;Connect Timeout=30");
        public addbook()
        {
            InitializeComponent();
        }

       

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text != "" && txtaname.Text != "" && txtpro.Text != "" && txtdate.Text != "" && txtprice.Text != "" && txtqunti.Text != "")
            {

                string name = txtbookname.Text;
                string aname = txtaname.Text;
                string pub = txtpro.Text;
                string date = txtdate.Text;
                Int64 price = Int64.Parse(txtprice.Text);
                Int64 qunt = Int64.Parse(txtqunti.Text);





                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into add_book(books_name,book_author_name,books_pablication,books_purchase_date,book_price,books_quantity) values ('" + name + "','" + aname + "','" + pub + "','" + date + "','" + price + "','" + qunt + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



                txtbookname.Clear();
                txtaname.Clear();
                txtpro.Clear();
                

                txtprice.Clear();
                txtqunti.Clear();
            }

        private void bbtnclear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your unsaved DATA", "Are you sure? ",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                 this.Close();
            }
            
        }
    }
}
