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
    public partial class mainscreen : Form
    {
        public mainscreen()
        {
            InitializeComponent();
        }

        private void aDDNEWEMPLOYEEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ADD_NEW_EMPLOYEE ad = new ADD_NEW_EMPLOYEE();
            ad.Show();
         
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UPDATE_EMPLOYEE ue = new UPDATE_EMPLOYEE();
            ue.Show();
       
        }

        private void phonegroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletegroupBox4.Visible = true;
            fillcombox(comboBox4);

        }
        public void fillcombox(ComboBox bx)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("select FrName from Employee", con);
            CMD.Parameters.AddWithValue("@FrName", bx.Text);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = CMD.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString("FrName");
                    bx.Items.Add(sname);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_clear_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("Delete Employee where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", comboBox4.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("delete"+ comboBox4.Text);
            con.Close();
        }

        private void datacustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_customer dc = new data_customer();
            dc.Show();
       
        }

        private void customerbuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_and_view dv = new delete_and_view();
            dv.Show();
      
        }

        private void sEARCHEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            deletegroupBox4.Visible = false;
            FillComboSeacrhCode();
            filldat();
            name_model(comboBox1);
        }

        private void supplydataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supply s = new supply();
            s.Show();
            
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department d = new department();
            d.Show();
            

        }

        private void mainscreen_Load(object sender, EventArgs e)
        {

        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            car c = new car();
            c.Show();
        }
       private void FillComboSeacrhCode()
        {
            comboBox1.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            con.Open();
            SqlCommand CMD;
            CMD = con.CreateCommand();
            CMD.CommandType = CommandType.Text;
            CMD.CommandText = "select FrName from Employee";
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
            string sql = "select FrName,id_employee from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            bx.DisplayMember = "FrName";
            bx.ValueMember = "id_employee";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            SqlCommand CMD = new SqlCommand("select * from Employee where id_employee=@id", con);
            CMD.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        private void filldat()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addcustomerbuyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
