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
    public partial class delete_and_view : Form
    {
        public delete_and_view()
        {
            InitializeComponent();
        }

        private void preiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filldatprem();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            deletegroupBox2.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filldatrent();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            deletegroupBox2.Visible = false;
        }
        private void filldatbuy()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select * from Data_customer D,Customer_buy C where D.id=C.customer_id";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_data.DataSource = dt;
            con.Close();
        }
        private void filldatrent()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select * from Data_customer D,Customer_rent C where D.id=C.customer_id";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_data.DataSource = dt;
            con.Close();
        }
        // premium 
        private void filldatprem()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select * from Data_customer D,Customer_premium C where D.id=C.customer_id";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_data.DataSource = dt;
            con.Close();
        }
        //select name ,name_type from Supplier S,supply_type st,type_car t
        // where S.id_supplier=st.supply_id and st.supply_id_type= t.id_type
   
        private void soldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filldatbuy();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            deletegroupBox2.Visible = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            deletegroupBox2.Visible = true;
        }

       
        public void serach()
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            String sql = "select FrName from Data_customer";
            // String sql = "select * from model_car";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            comboBox1.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            comboBox1.DisplayMember = "FrName";
            comboBox1.ValueMember = "id";

        }
       
        private void FillComboSeacrhCode()
        {
            comboBox1.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            con.Open();
            SqlCommand CMD;
            CMD = con.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select FrName from Data_customer";
            CMD.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["FrName"].ToString());
            }
            con.Close();

            //new SqlCommand("select FrName from Employee", con);
        }
        public void name_model(ComboBox bx)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            string sql = "select FrName,id from Data_customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            bx.DisplayMember = "FrName";
            bx.ValueMember = "id";
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            deletegroupBox2.Visible = false;
            serach();
            FillComboSeacrhCode();
            name_model(comboBox1);
            
        }

        private void search_btn_Click(object sender, EventArgs e)
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
            SqlCommand CMD = new SqlCommand("select * from Data_customer where id=@id", con);
            CMD.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_serach.DataSource = dt;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
