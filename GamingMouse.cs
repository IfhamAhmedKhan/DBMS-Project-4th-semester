using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProjectIETYTechZone
{
    public partial class GamingMouse : MetroFramework.Forms.MetroForm
    {
        public GamingMouse()
        {
            InitializeComponent();
        }

        private void GamingMouse_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            BuyProduct obj1 = new BuyProduct();
            obj1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyProduct obj1 = new BuyProduct();
            obj1.Show();
            this.Close();
        }
    }
}
