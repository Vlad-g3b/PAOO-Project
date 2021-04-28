using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(password.Text == "admin" && username.Text == "admin")
            {
                MessageBox.Show("Logged in!");
                Form main = new main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Numele sau parola sunt gresite!");
            }
        }

    }
}
