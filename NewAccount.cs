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
    public partial class NewAccount : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        public NewAccount()
        {
            InitializeComponent();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-8H2HJRO\\IFHAMKHAN;Initial Catalog=IEYTProject;Integrated Security=True");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;
            string phone = textBox4.Text;

            string query = " INSERT INTO UserInfo(Username, UserPassword, Email, Phone)" + " VALUES ('" + name + "','" + password + "','" + email + "','" + phone + "')";
            string query2 = "Insert Into TableLogin(Username, UserPassword)" + "Values('" + name + "','" + password + "')";
            SqlCommand work1 = new SqlCommand(query2, conn);
            SqlCommand work = new SqlCommand(query, conn);
            conn.Open();
            work.ExecuteNonQuery();
            work1.ExecuteNonQuery();
            
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                MessageBox.Show(textBox1.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(textBox2.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(textBox3.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(textBox4.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login obj = new Login();
                obj.Show();
                this.Close();
            }
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text)) {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter your username!");
            }
            else {
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
                errorProvider2.SetError(textBox3, "Please enter your Email!");
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
                errorProvider4.SetError(textBox4, null);
            }
        }
    }
}
