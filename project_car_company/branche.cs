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
    public partial class branche : Form
    {
        public branche()
        {
            InitializeComponent();
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
        public void customer(ComboBox bx)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            string sql = "select id,FrName, from Data_customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            bx.DisplayMember = "FrName";
            bx.ValueMember = "id";
        }
        public void Location(ComboBox bx)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            string sql = "select id_branche ,LOCATION from Branches";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            bx.DisplayMember = "LOCATION";
            bx.ValueMember = "id_branche";
        }
        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model_car(comboBox4);
            employee(comboBox5);
            Location(comboBox6);
            panel1.Visible = false;
            panel3.Visible = true;
            groupBox2.Visible = false;
        }
        //


        private void viewDataOfCarSoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            groupBox2.Visible = true;
            filldat();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("insert into Branches(LOCATION,customer_id,car_id,employee_id)values(@LOCATION,@customer_id,@car_id,employee_id)", con);
            CMD.Parameters.AddWithValue("@Name", textBox1.Text);
            CMD.Parameters.AddWithValue("@LOCATION", textBox1.Text);
            CMD.Parameters.AddWithValue("@employee_id", this.comboBox7.SelectedValue);

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

        private void aDDNEWBRANCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model_car(comboBox1);
            employee(comboBox7);
            panel1.Visible = true;
            panel3.Visible = false;
            groupBox2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Branches set employee_id=@employee_id where LOCATION=@LOCATION", con);
            con.Open();
            CMD.Parameters.AddWithValue("@LOCATION", this.comboBox6.Text);
            CMD.Parameters.AddWithValue("@employee_id", comboBox5.SelectedValue);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Branches set car_id=@car_id where LOCATION=@LOCATION", con);
            con.Open();
            CMD.Parameters.AddWithValue("@LOCATION", this.comboBox6.Text);
            CMD.Parameters.AddWithValue("@car_id", comboBox4.SelectedValue);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void branche_Load(object sender, EventArgs e)
        {

        }
        private void filldat()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select * from Data_customer D,Customer_buy C where D.id=C.customer_id";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void viewDataOfCarRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filldatre();

        }
        private void filldatre()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select * ,m.List_price from Data_customer D,Customer_rent C ,type_car ,model_car m where D.id = C.customer_id and D.car_type = type_car.id_type and type_car.id_type = m.type_id";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
