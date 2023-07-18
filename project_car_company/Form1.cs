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

namespace project_car_company
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            welcome_pic.Image = Resource1.welcome_2;
            button1.BackgroundImage = Resource1.car_two;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.BackgroundImage = Resource1.exit2;
            welcome_pic.Image = Resource1.welcome;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            welcome_pic.Image = Resource1.welcome;
            button1.BackgroundImage = Resource1.download;
        }

        private void exit_btn_MouseMove(object sender, MouseEventArgs e)
        {
            welcome_pic.Image = Resource1.welcome;
            exit_btn.BackgroundImage = Resource1.exit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection();
            // SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
             SqlCommand cmd = new SqlCommand("select * from Employee where FrName='" + user_name.Text + "'and Ssn='" + password.Text + "'", con);
             con.Open();
             SqlDataReader dr = cmd.ExecuteReader();
             if (user_name.Text.Length != 0 || password.Text.Length != 0)
             {


                 if (dr.Read() || (user_name.Text == "admin" && password.Text == "admin"))
                 {
                     mainscreen ms = new mainscreen();
                     ms.Show();
                     this.Hide();

                 }
                 else
                 {
                     MessageBox.Show("renter your name or Ssn ");
                 }

             }
             con.Close();*/
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Employee where FrName='" + user_name.Text + "'and Ssn='" + password.Text + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (user_name.Text.Length != 0 || password.Text.Length != 0)
            {


                if (dr.Read() || (user_name.Text == "admin" && password.Text == "admin"))
                {
                    mainscreen ms = new mainscreen();
                    ms.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("renter your name or Ssn ");
                }

            }
            con.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
