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
    public partial class data_customer : Form
    {
        public data_customer()
        {
            InitializeComponent();
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_customer uc = new update_customer();
            uc.Show();
            this.Hide();
        }
    

      /*  public void type_of_car(ComboBox bx)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand type_car = new SqlCommand("select name_type from type_car", con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = type_car.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString("name_type");
                    bx.Items.Add(sname);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        public void model_car()
        {
            string car_deatail = "car detail";    
             SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
         String sql = "select name_type+'||'+name_model as'" + car_deatail + "',id_type,type_id from type_car,model_car where type_car.id_type = model_car.type_id";
           // String sql = "select * from model_car";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            car_model_combo.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            car_model_combo.DisplayMember =car_deatail;
            car_model_combo.ValueMember = "type_id";
            
        }
        public void branche_detail()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            string brancHE_name = "name of branche"+" id_branche";
            string sql = "select LOCATION as'" + brancHE_name + "',customer_id from Branches B ,Data_customer D ,type_car t where  B.car_id=t.id_type";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            branchecomboBox5.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";*/
            branchecomboBox5.DisplayMember = brancHE_name;
            branchecomboBox5.ValueMember = brancHE_name;
        }
     

        private void data_customer_Load(object sender, EventArgs e)
        {
           // type_of_car(type_car_combo);
            model_car();
            branche_detail();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_book_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            
        }
        private void service_buy()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            con.Open();
            String sql = "insert into Customer_buy(Customer_id) values(@Customer_id)";
            /* String sql = "select * from model_car";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable de = new DataTable();
            da.Fill(de);
            bx.DataSource = de;
            /* car_model_combo.DisplayMember = "name_model";
             car_model_combo.ValueMember = "id_model";
            bx.DisplayMember = car_deatail;
            bx.ValueMember = "type_id";*/
            SqlCommand CMD = new SqlCommand(sql, con);

        }
        private void dateTimePicker2_recive_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_and_view dv = new delete_and_view();
            dv.Show();
            this.Hide();
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("insert into Data_customer(FrName,LaName,Gender,B_date,Ssn,phone_one,date_book,date_recive,address,car_type,Branche)values(@FrName,@LaName,@Gender,@DB,@Ssn,@phone_one,@date_book,@date_recive,@address,@car_type,@Branche)", con);
            CMD.Parameters.AddWithValue("@FrName", fr_tb.Text);
            CMD.Parameters.AddWithValue("@LaName", last_tb.Text);
            CMD.Parameters.AddWithValue("@Gender", this.comboBox1.Text);
            CMD.Parameters.AddWithValue("@DB", this.dateTimePicker3_brith.Text);
            CMD.Parameters.AddWithValue("@Ssn", id_tb.Text);
            CMD.Parameters.AddWithValue("@phone_one", phone_one_tb.Text);
            CMD.Parameters.AddWithValue("@date_book", this.dateTimePicker1_book.Text);
            CMD.Parameters.AddWithValue("@date_recive", this.dateTimePicker2_recive.Text);
            CMD.Parameters.AddWithValue("@address", email_tb.Text);
            CMD.Parameters.AddWithValue("@car_type", car_model_combo.SelectedValue); 
            CMD.Parameters.AddWithValue("@Branche", branchecomboBox5.SelectedValue);
           // SqlCommand cmd_status = new SqlCommand("insert into Customer_buy(customer_id)values(@customer_id)");         
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

        private void aDDNEWCUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_and_view dv = new delete_and_view();
        }
    }
}
