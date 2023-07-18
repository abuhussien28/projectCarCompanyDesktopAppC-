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
            name_model(comboBox2);
        }


        public void serach()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            String sql = "select FrName, id from Data_customer"; // Include the column you want to use as the value member
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            comboBox1.DataSource = de;
            comboBox1.DisplayMember = "FrName";
            comboBox1.ValueMember = "id"; // Adjust the value member column name to match your DataTable
        }

       /* private void FillComboSeacrhCode()
        {
            comboBox1.DataSource = null; // Clear the data source before modifying the items
            comboBox1.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            con.Open();
            SqlCommand CMD = con.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select FrName from Data_customer";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            da.Fill(dt);
            comboBox1.DataSource = dt; // Set the data source instead of adding items individually
            comboBox1.DisplayMember = "FrName";
            comboBox1.ValueMember = null; // Set the value member if needed
            con.Close();
        }*/
        private void filldat()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select * from Data_customer";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_serach.DataSource = dt;
            con.Close();
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
            bx.DisplayMember = "FrName";
            bx.ValueMember = "id";
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            deletegroupBox2.Visible = false;
            name_model(comboBox1);
            serach();
            //FillComboSeacrhCode();
            filldat();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            con.Open();
            SqlCommand CMD = new SqlCommand("select * from Data_customer where id=@id", con);
            CMD.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CMD.ExecuteNonQuery();
            dataGridView_serach.DataSource = dt;
            con.Close();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_clear_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("Delete From Data_customer where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", comboBox2.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("delete  " + comboBox2.Text);
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
