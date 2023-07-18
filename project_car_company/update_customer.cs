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
    public partial class update_customer : Form
    {
        public update_customer()
        {
            InitializeComponent();
        }
        public void fillcombox(ComboBox bx)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("select FrName from Data_customer", con);
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
        private void update_phone_btn_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Data_customer set phone_one=@phone_one where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.frist_fristcomboBox4.Text);
            CMD.Parameters.AddWithValue("@phone_one", phone_tb.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phonegroupBox4.Visible = true;
            daterecivegroupBox3.Visible = false;
            date_bookgroupBox6.Visible = false;
            frist_namegroupBox4.Visible = false;
            last_namegroupBox5.Visible = false;
            service_typecomboBox6.Visible = false;
            SsngroupBox2.Visible = false;
            addressgroupBox1.Visible = false;
            phonegroupBox4.Location = new Point(100, 100);
            fillcombox(frist_fristcomboBox4);
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reciveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            phonegroupBox4.Visible = false;
            daterecivegroupBox3.Visible = true;
            date_bookgroupBox6.Visible = false;
            frist_namegroupBox4.Visible = false;
            last_namegroupBox5.Visible = false;
            service_typecomboBox6.Visible = false;
            SsngroupBox2.Visible = false;
            addressgroupBox1.Visible = false;
            daterecivegroupBox3.Location = new Point(100, 100);
            fillcombox(frist_datacomboBox3);
        }

        private void update_date_recive_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Data_customer set date_recive=@date_recive where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.frist_datacomboBox3.Text);
            CMD.Parameters.AddWithValue("@date_recive", this.datereciveTimePicker1.Value);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void button2_clear_Click(object sender, EventArgs e)
        {
            frist_fristcomboBox4.SelectedItem = null;
            phone_tb.Clear();
        }

        private void button1_clear_Click(object sender, EventArgs e)
        {
            frist_datacomboBox3.SelectedItem = null;
            this.datereciveTimePicker1.Value = DateTime.Today;
        }

        private void update_ssn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Data_customer set Ssn=@Ssn where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.comboBox2.Text);
            CMD.Parameters.AddWithValue("@Ssn", textBox1.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void button4_clear_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = null;

            textBox1.Clear();
        }

        private void nationalIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            phonegroupBox4.Visible = false;
            daterecivegroupBox3.Visible = false;
            date_bookgroupBox6.Visible = false;
            frist_namegroupBox4.Visible = false;
            last_namegroupBox5.Visible = false;
            service_typegroupBox2.Visible = false;
            SsngroupBox2.Visible = true;
            addressgroupBox1.Visible = false;
            SsngroupBox2.Location = new Point(100, 100);
            fillcombox(comboBox2);
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            phonegroupBox4.Visible = false;
            daterecivegroupBox3.Visible = false;
            date_bookgroupBox6.Visible = true;
            frist_namegroupBox4.Visible = false;
            last_namegroupBox5.Visible = false;
            service_typegroupBox2.Visible = false;
            SsngroupBox2.Visible = false;
            addressgroupBox1.Visible = false;
            date_bookgroupBox6.Location = new Point(100, 100);
            fillcombox(comboBox10);
        }

        private void update_datebook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Data_customer set date_book=@date_book where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.frist_datacomboBox3.Text);
            CMD.Parameters.AddWithValue("@date_book", this.dateTimePicker2.Value);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void delete_date_book_Click(object sender, EventArgs e)
        {
            comboBox10.SelectedItem = null;
            this.dateTimePicker2.Value = DateTime.Today;
        }

        private void servicetypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            phonegroupBox4.Visible = false;
            daterecivegroupBox3.Visible = false;
            date_bookgroupBox6.Visible = false;
            frist_namegroupBox4.Visible = false;
            last_namegroupBox5.Visible = false;
            service_typegroupBox2.Visible = true;
            SsngroupBox2.Visible = false;
            addressgroupBox1.Visible = false;
            service_typegroupBox2.Visible = true;
            service_typegroupBox2.Location = new Point(100, 100);
            ser.Visible = true;
            fillcombox(frist_servicecomboBox5);
        }

        private void update_service_type_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Data_customer set service_type=@service_type where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.frist_servicecomboBox5.Text);
            CMD.Parameters.AddWithValue("@service_type", this.service_typecomboBox6.SelectedItem.ToString());
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void fristNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            phonegroupBox4.Visible = false;
            daterecivegroupBox3.Visible = false;
            date_bookgroupBox6.Visible = false;
            frist_namegroupBox4.Visible = true;
            last_namegroupBox5.Visible = false;
            service_typegroupBox2.Visible = false;
            SsngroupBox2.Visible = false;
            addressgroupBox1.Visible = false;
            frist_namegroupBox4.Location = new Point(100, 100);
            fillcombox(frist_namecomboBox8);
        }

        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            phonegroupBox4.Visible = false;
            daterecivegroupBox3.Visible = false;
            date_bookgroupBox6.Visible = false;
            frist_namegroupBox4.Visible = false;
            last_namegroupBox5.Visible = true;
            service_typegroupBox2.Visible = false;
            SsngroupBox2.Visible = false;
            addressgroupBox1.Visible = false;
            last_namegroupBox5.Location = new Point(100, 100);
            fillcombox(fristlast_namecomboBox9);
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {

            phonegroupBox4.Visible = false;
            daterecivegroupBox3.Visible = false;
            date_bookgroupBox6.Visible = false;
            frist_namegroupBox4.Visible = false;
            last_namegroupBox5.Visible = false;
            service_typegroupBox2.Visible = false;
            SsngroupBox2.Visible = false;
            addressgroupBox1.Visible = true;
            addressgroupBox1.Location = new Point(100, 100);
            fillcombox(comboBox1);
        }

        private void update_address_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Data_customer set address=@address where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.comboBox1.Text);
            CMD.Parameters.AddWithValue("@address", textBox2.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void update_frist_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Data_customer set FrName=@FrName_ed where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.frist_namecomboBox8.Text);
            CMD.Parameters.AddWithValue("@FrName_ed", frist_desgin_tb.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void update_last_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Data_customer set LaName=@LaName where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.fristlast_namecomboBox9.Text);
            CMD.Parameters.AddWithValue("@LaName", last_nametextBox6.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void clear_address_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            textBox2.Clear();
        }

        private void clear_frist_Click(object sender, EventArgs e)
        {
            frist_namecomboBox8.SelectedItem = null;
            phone_tb.Clear();
        }

        private void clear_last_Click(object sender, EventArgs e)
        {
            fristlast_namecomboBox9.SelectedItem = null;
            last_nametextBox6.Clear();
        }

        private void clear_service_Click(object sender, EventArgs e)
        {
            frist_servicecomboBox5.SelectedItem = null;
           service_typecomboBox6.SelectedItem = null;
        }
    }
}
