using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_car_company
{
    public partial class supply : Form
    {
        public supply()
        {
            InitializeComponent();
        }
    
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // SqlCommand CMD = new SqlCommand("insert into Employee values(" @FrName,@LaName,@Ssn,@DB,@Email,@Gender,@phone_one,@phone_two" +
            //   ")", con);
            SqlCommand CMD = new SqlCommand("insert into Supplier (name,phone,location)values(@name,@phone,@location)", con);
            CMD.Parameters.AddWithValue("@name", textBox7.Text);
            CMD.Parameters.AddWithValue("@phone", textBox2.Text);
            CMD.Parameters.AddWithValue("@location", textBox1.Text);
            //   DateTime value = dateTimePicker1.Value;
          
            //CMD.Parameters.AddWithValue("@phone_two", phone_two_tb.Text);
            con.Open();
            int raweffect = CMD.ExecuteNonQuery();
            if (raweffect > 0)
            {
                MessageBox.Show("added success :))");
            }

            else
            { MessageBox.Show("not added :(("); }

            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void supply_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // SqlCommand CMD = new SqlCommand("insert into Employee values(" @FrName,@LaName,@Ssn,@DB,@Email,@Gender,@phone_one,@phone_two" +
            //   ")", con);
            SqlCommand CMD = new SqlCommand("insert into parts (name,List_price)values(@name,@List_price)", con);
            CMD.Parameters.AddWithValue("@name", textBox8.Text);
            CMD.Parameters.AddWithValue("@List_price", textBox3.Text);
           // CMD.Parameters.AddWithValue("@location", textBox1.Text);
            //   DateTime value = dateTimePicker1.Value;

            //CMD.Parameters.AddWithValue("@phone_two", phone_two_tb.Text);
            con.Open();
            int raweffect = CMD.ExecuteNonQuery();
            if (raweffect > 0)
            {
                MessageBox.Show("added success :))");
            }

            else
            { MessageBox.Show("not added :(("); }

            con.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void newSupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;
           
        }

        private void newPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = true;
            panel1.Visible = false;
        }
        
        private void supplierTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_supply vs = new view_supply();
            vs.Show();
        }
       
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
