using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insert Code goes here

            try {

                string MyConnection = "server=localhost; userId=root; password=; database=esoftstudent";

                string query = "INSERT INTO `student` (`id`, `name`, `address`, `gender`, `course`, `phone`) VALUES ('" + this.txt_id.Text + "', '" + this.txt_name.Text + "', '" + this.txt_address.Text + "', '" + this.txt_gender.Text + "', '" + this.txt_course.Text + "', '" + this.txt_phone.Text + "' );";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Registration Sucessful", "Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // View Code 

            try
            {

                if (txt_id.Text != "")
                {

                    string MyConnection = "server=localhost; userId=root; password=; database=esoftstudent";
                    string query = "SELECT * FROM `student` WHERE id= '" + txt_id.Text + "'";
                    MySqlConnection Myconn = new MySqlConnection(MyConnection);
                    MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                    MySqlDataReader MyReader;
                    Myconn.Open();
                    MyReader = Mycommand.ExecuteReader();
                    Myconn.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(Mycommand);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    txt_name.Text = dt.Rows[0][1].ToString();
                    txt_address.Text = dt.Rows[0][2].ToString();
                    txt_gender.Text = dt.Rows[0][3].ToString();
                    txt_course.Text = dt.Rows[0][4].ToString();
                    txt_phone.Text = dt.Rows[0][5].ToString();

                }

                else
                {

                    MessageBox.Show("Enter Value for ID");

                }

            }
            catch {

                MessageBox.Show("Error");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Update Code

            try {

                string MyConnection = "server=localhost; userId=root; password=; database=esoftstudent";

                string query = "UPDATE `student` SET `id` = '" + this.txt_id.Text + "', `name` = '" +this.txt_name.Text + "', `address` ='" +this.txt_address.Text + "', `gender`= '"+this.txt_gender.Text+"', `course`= '" + this.txt_course.Text + "', `phone` = '" + this.txt_phone.Text + "' WHERE `id`= '"+this.txt_id.Text+"'";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Successfully Updated");
                while(MyReader.Read())
                    Myconn.Close();


            } catch (Exception ex){

                MessageBox.Show(ex.Message);
            }


        }
    }
}
