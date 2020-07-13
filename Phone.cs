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

namespace TelephoneDiary
{
    public partial class Phone : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TVBPA8T;Initial Catalog=PhoneCatalogue;Integrated Security=True");
        
        public Phone()
        {
            InitializeComponent();
        }

        private void Phone_Load(object sender, EventArgs e)
        {
            DisplayInGrid();
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            tBoxEmail.Text = "";
            tBoxFirstName.Text = "";
            tBoxLastName.Text = "";
            tBoxMobile.Text = "";
            comBoxCategory.SelectedIndex = -1;
            tBoxFirstName.Focus();
        }

        private void bttInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scm = new SqlCommand(@"Insert into Contacts
                (FirstName, LastName, Mobile, Email, Category)
                Values ('" + tBoxFirstName.Text + "', '" + 
                             tBoxLastName.Text + "', '" + 
                             tBoxMobile.Text + "', '" + 
                             tBoxEmail.Text + "', '" + 
                             comBoxCategory.Text + "')", con);
            /*
             * SqlCommand -> Only for sending data to Sql (Insert, Update, Delete)
             * SqlDataReader -> Only for reading data (Select)
             * SqlDataAdapter -> All operations, much slower, No need con.Open() and con.Close()
             */
            scm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New contact successfully saved");
            DisplayInGrid();
        }

        void DisplayInGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Contacts", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["FirstName"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["LastName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Mobile"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            tBoxFirstName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tBoxLastName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tBoxMobile.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tBoxEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comBoxCategory.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scm = new SqlCommand(@"Delete from Contacts
                where (Mobile = '" + tBoxMobile.Text + "')", con);

            scm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Selected contact successfully deleted");
            DisplayInGrid();
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scm = new SqlCommand(@"UPDATE Contacts
                SET FirstName = '" + tBoxFirstName.Text + "', LastName = '" +
                                     tBoxLastName.Text + "', Mobile = '" +
                                     tBoxMobile.Text + "', Email = '" +
                                     tBoxEmail.Text + "', Category = '" +
                                     comBoxCategory.Text +
                "' where (Mobile = '" + tBoxMobile.Text + "')", con);           
            
            scm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Contact successfully updated");
            DisplayInGrid();
        }

        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "";
            switch (comBoxSearch.Text)
            {
                case "First Name":
                        connectionString = "Select * from Contacts Where FirstName like '" + tBoxSearch.Text + "%'";                    
                    break;
                case "Last Name":
                        connectionString = "Select * from Contacts Where LastName like '" + tBoxSearch.Text + "%'";                   
                    break;
                case "Mobile":
                        connectionString = "Select * from Contacts Where Mobile like '" + tBoxSearch.Text + "%'";                    
                    break;
                case "Category":
                        connectionString = "Select * from Contacts Where Category like '" + tBoxSearch.Text + "%'";                   
                    break;
            }
            SqlDataAdapter sda = new SqlDataAdapter(connectionString, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["FirstName"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["LastName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Mobile"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
        }
    }
}
