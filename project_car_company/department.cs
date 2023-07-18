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
    public partial class department : Form
    {
        public department()
        {
            InitializeComponent();
        }

        private void brunchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            branche b = new branche();
            b.Show();
        }

        private void fr_tb_TextChanged(object sender, EventArgs e)
        {

        }
        public void depart_name()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            string sql = "select Name from Department";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            comboBox3.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Name";
        }
        public void employee(ComboBox bx)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
           // string brancHE_name = "id_employee" + " id_branche";
            string sql = "select id_employee,FrName from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            bx.DisplayMember = "FrName";
            bx.ValueMember = "id_employee";
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("insert into Department(Name,LOCATION,employee_id)values(@Name,@LOCATION,@employee_id)", con);
            CMD.Parameters.AddWithValue("@Name", fr_tb.Text);
            CMD.Parameters.AddWithValue("@LOCATION", textBox1.Text);
            CMD.Parameters.AddWithValue("@employee_id", this.comboBox2.SelectedValue);

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

        private void department_Load(object sender, EventArgs e)
        {

        }

        private void aDDNEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee(comboBox2);
            panel1.Visible = true;
            panel3.Visible = false;
  
            groupBox2.Visible = false;
          
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee(comboBox1);
            depart_name();
            panel1.Visible = false;
            panel3.Visible = true;
           
           
            groupBox2.Visible = false;
           
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panel3.Visible = false;
      
            groupBox2.Visible = true;
           
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Department set employee_id=@employee_id where name=@name", con);
            con.Open();
            CMD.Parameters.AddWithValue("@name", this.comboBox3.Text);
            CMD.Parameters.AddWithValue("@employee_id", comboBox1.SelectedValue);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
        public void name_model(ComboBox bx)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            string sql = "select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            bx.DisplayMember = "FrName";
            bx.ValueMember = "id_employee";
        }

        private void sEARCHTYPEANDMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void uPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            /*  SqlCommand CMD;
              CMD = con.CreateCommand();
              CMD.CommandType = CommandType.Text;
              SqlDataAdapter da = new SqlDataAdapter("select * from Employee where id_employee= '"+ comboBox1.Text + "'",con);
              DataTable dt = new DataTable();
              da.Fill(dt);
              comboBox1.SelectedValue = dt.Rows[0].ToString();
              con.Close();*/
            SqlCommand CMD = new SqlCommand("select * from Employee where id_employee=@id", con);
            CMD.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void departmentdataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
