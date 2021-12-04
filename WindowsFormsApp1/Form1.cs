using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_pw.Clear();
            txt_un.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = txt_un.Text;
            string password = txt_pw.Text;

            if (user == "Sahan" && password == "1234")
            {

                MessageBox.Show("Login Sucessfull");
                menu open_menu = new menu();
                open_menu.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("Login Unsuccessfull");
            }
        }
    }
}
