using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace project_car_company
{
    public partial class ADD_NEW_EMPLOYEE : Form
    {
        public ADD_NEW_EMPLOYEE()
        {
            InitializeComponent();
        }

        private void ADD_NEW_EMPLOYEE_Load(object sender, EventArgs e)
        {
            
        }
        string imgLocation;
        string imgLocation2;
     
      
            private void label1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void CV_label_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation2 = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imgLocation2;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            //cv image
            byte[] images2 = null;
            FileStream stream2 = new FileStream(imgLocation2, FileMode.Open, FileAccess.Read);
            BinaryReader brs2 = new BinaryReader(stream2);
            images2 = brs2.ReadBytes((int)stream2.Length);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // SqlCommand CMD = new SqlCommand("insert into Employee values(" @FrName,@LaName,@Ssn,@DB,@Email,@Gender,@phone_one,@phone_two" +
            //   ")", con);
            SqlCommand CMD = new SqlCommand("insert into Employee (FrName,LaName,Ssn,DB,Email,Gender,phone_one,person_image,Cv_image)values(@FrName,@LaName,@Ssn,@DB,@Email,@Gender,@phone_one,@person_image,@Cv_image)", con);
            CMD.Parameters.AddWithValue("@FrName", fr_tb.Text);
            CMD.Parameters.AddWithValue("@LaName", last_tb.Text);
            CMD.Parameters.AddWithValue("@Ssn", id_tb.Text);
            //   DateTime value = dateTimePicker1.Value;
            CMD.Parameters.AddWithValue("@DB", this.dateTimePicker1.Text);
            CMD.Parameters.AddWithValue("@Email", email_tb.Text);
            CMD.Parameters.AddWithValue("@Gender", this.comboBox1.Text);
            CMD.Parameters.AddWithValue("@phone_one", phone_one_tb.Text);
            CMD.Parameters.AddWithValue("@person_image", images);
            CMD.Parameters.AddWithValue("@Cv_image", images2);
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


        private void view_Click(object sender, EventArgs e)
        {
            /* string sql = "select person_image from Employee where FrName='" + fr_tb.Text + "' ";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                SqlCommand CMD = new SqlCommand(sql, con);
                SqlDataReader reader = CMD.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mst = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(mst);
                    }
                }

                else
                {
                    con.Close();
                    MessageBox.Show("image does not exist!");
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr_tb.Clear();
            last_tb.Clear();
            id_tb.Clear();
            email_tb.Clear();
            phone_one_tb.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            comboBox1.SelectedItem = null;
            this.dateTimePicker1.Value = DateTime.Today;
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void phone_two_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_two_label_Click(object sender, EventArgs e)
        {

        }

        private void phone_one_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_one_label_Click(object sender, EventArgs e)
        {

        }

        private void gender_label_Click(object sender, EventArgs e)
        {

        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_label_Click(object sender, EventArgs e)
        {

        }

        private void d_b_label_Click(object sender, EventArgs e)
        {

        }

        private void id_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void National_ID_label_Click(object sender, EventArgs e)
        {

        }

        private void last_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Last_name_label_Click(object sender, EventArgs e)
        {

        }

        private void fr_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frist_name_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
