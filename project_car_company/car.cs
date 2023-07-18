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
    public partial class car : Form
    {
        public car()
        {
            InitializeComponent();
        }

        private void car_Load(object sender, EventArgs e)
        {
           
        }
        public void name_model(ComboBox bx)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            string sql = "select name_model from model_car";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            bx.DisplayMember = "name_model";
            bx.ValueMember = "name_model";
        }
        public void model_car(ComboBox bx)
        {
            string car_deatail = "car detail";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            String sql = "select name_type+'||'+name_model as'" + car_deatail + "',id_type,type_id from type_car,model_car where type_car.id_type = model_car.type_id";
            // String sql = "select * from model_car";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            bx.DisplayMember = car_deatail;
            bx.ValueMember = "type_id";

        }
        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("insert into type_car(name_type)values(@name_type)", con);
            CMD.Parameters.AddWithValue("@name_type", textBox7.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("insert into model_car(name_model,List_price,type_id)values(@name_model,@List_price,@type_id)", con);
          
            CMD.Parameters.AddWithValue("@name_model", textBox3.Text);
            CMD.Parameters.AddWithValue("@List_price", textBox4.Text);
            CMD.Parameters.AddWithValue("@type_id", comboBox1.SelectedValue);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            model_car(comboBox1);
            panel3.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            dataGridView1.Visible = false;
        }

        private void updateModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            name_model(comboBox2);
            model_car(comboBox3);
            dataGridView1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update model_car set type_id=@type_id  where name_model=@name_model", con);
            con.Open();
            CMD.Parameters.AddWithValue("@LOCATION", this.comboBox2.SelectedValue);
            CMD.Parameters.AddWithValue("@type_id", comboBox3.SelectedValue);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update model_car set List_price=@List_price  where name_model=@name_model", con);
            con.Open();
            CMD.Parameters.AddWithValue("@name_model", this.comboBox2.SelectedValue);
            CMD.Parameters.AddWithValue("@List_price", textBox2.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void typeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = false;
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            filldat();
        }
        private void filldat()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select * from model_car";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
