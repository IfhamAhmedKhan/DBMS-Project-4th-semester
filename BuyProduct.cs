using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProjectIETYTechZone
{
    public partial class BuyProduct : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        public BuyProduct()
        {
            InitializeComponent();
        }

        private void BuyProduct_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-8H2HJRO\\IFHAMKHAN;Initial Catalog=IEYTProject;Integrated Security=True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox5.Enabled = false;
            }
            else {
                textBox5.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string address = textBox3.Text;
            string phone = textBox4.Text;
            string pay;
            if (radioButton1.Checked == true)
            {
                 pay = "COD";
            }
            else {
                pay = "Card";
            }
            

            string query = " INSERT INTO CheckOut(Username, UserPassword, UserAddress, Phone, PaymentMethod)" + " VALUES ('" + name + "','" + password + "','" + address + "','" + phone + "','" + pay + "')";
            SqlCommand work = new SqlCommand(query, conn);
            conn.Open();
            work.ExecuteNonQuery();
            MessageBox.Show("Your product is in delivery process thanks for using our application");
            MainPage obj = new MainPage();
            obj.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainPage obj = new MainPage();
            obj.Show();
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter your Username!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please enter your Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, null);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider3.SetError(textBox3, "Please enter your Address!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(textBox3, null);
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider4.SetError(textBox4, "Please enter your Phone number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox4, null);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
