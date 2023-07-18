using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace project_car_company
{
    public partial class UPDATE_EMPLOYEE : Form
    {
        public UPDATE_EMPLOYEE()
        {
            InitializeComponent();
            //fillcombox();
        }
        string imgLocation;
        string imgLocation2;
        private void UPDATE_EMPLOYEE_Load(object sender, EventArgs e)
        {
            CVgroupBox5.Visible = false;
            picturegroupBox1.Visible = false;
            emailgroupBox3.Visible = false;
            phonegroupBox4.Visible = false;
            SsngroupBox2.Visible = false;
        }
        public void fillcombox(ComboBox bx)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("select FrName from Employee",con);
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            /* byte[] images = null;
             FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
             BinaryReader brs = new BinaryReader(stream);
             images = brs.ReadBytes((int)stream.Length);
             //cv image
             byte[] images2 = null;
             FileStream stream2 = new FileStream(imgLocation2, FileMode.Open, FileAccess.Read);
             BinaryReader brs2 = new BinaryReader(stream2);
             images2 = brs2.ReadBytes((int)stream2.Length);
             SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
             SqlCommand CMD = new SqlCommand("update Employee set Ssn=@Ssn,Email=@Email,phone_one=@phone_one,person_image=@person_image,Cv_image=@Cv_image where FrName=@FrName", con);
             CMD.Parameters.AddWithValue("@Ssn", id_tb.Text);
             CMD.Parameters.AddWithValue("@Email", email_tb.Text);
             CMD.Parameters.AddWithValue("@phone_one", phone_one_tb.Text);
             CMD.Parameters.AddWithValue("@person_image", images);
             CMD.Parameters.AddWithValue("@Cv_image", images2);
             CMD.Parameters.AddWithValue("@FrName", this.comboBox1.Text);*/
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Employee set Email=@Email where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.comboBox3.Text);
            CMD.Parameters.AddWithValue("@Email", textBox2.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

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
           
           /* id_tb.Clear();
            email_tb.Clear();
            phone_one_tb.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            comboBox1.SelectedItem = null;*/
          
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVgroupBox5.Visible = false;
            picturegroupBox1.Visible = false;
            emailgroupBox3.Visible = false;
            phonegroupBox4.Visible = true;
            SsngroupBox2.Visible = false;
            phonegroupBox4.Location = new Point(100, 100);
            fillcombox(comboBox4);
        }

        private void cvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVgroupBox5.Visible = true;
            picturegroupBox1.Visible = false;
            emailgroupBox3.Visible = false;
            phonegroupBox4.Visible = false;
            SsngroupBox2.Visible = false;
            CVgroupBox5.Location = new Point(100, 100);
            fillcombox(comboBox1);
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVgroupBox5.Visible = false;
            picturegroupBox1.Visible = false;
            emailgroupBox3.Visible = true;
            phonegroupBox4.Visible = false;
            SsngroupBox2.Visible = false;
            emailgroupBox3.Location = new Point(100, 100);
            fillcombox(comboBox3);
        }

        private void pictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVgroupBox5.Visible = false;
            picturegroupBox1.Visible = true;
            emailgroupBox3.Visible = false;
            phonegroupBox4.Visible = false;
            SsngroupBox2.Visible = false;
            picturegroupBox1.Location = new Point(100, 100);
            fillcombox(comboBox5);
        }

        private void nationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVgroupBox5.Visible = false;
            picturegroupBox1.Visible = false;
            emailgroupBox3.Visible = false;
            phonegroupBox4.Visible = false;
            SsngroupBox2.Visible = true;
            SsngroupBox2.Location = new Point(100, 100);
            fillcombox(comboBox2);
        }

        private void update_phone_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Employee set phone_one=@phone_one where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.comboBox4.Text);
            CMD.Parameters.AddWithValue("@phone_one",textBox3.Text);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();

        }

        private void update_btn_cv_Click(object sender, EventArgs e)
        {
            //string imgLocation2;
          /*  string imgLocation;
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);*/
            //cv image
            byte[] images2 = null;
            FileStream stream2 = new FileStream(imgLocation2, FileMode.Open, FileAccess.Read);
            BinaryReader brs2 = new BinaryReader(stream2);
            images2 = brs2.ReadBytes((int)stream2.Length);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Employee set Cv_image=@Cv_image where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.comboBox1.Text);
            CMD.Parameters.AddWithValue("@Cv_image", images2);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();

        }

        private void update_picture_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Employee set person_image=@person_image where FrName=@FrName", con);
            con.Open();
            CMD.Parameters.AddWithValue("@FrName", this.comboBox5.Text);
            CMD.Parameters.AddWithValue("@person_image", images);
            CMD.ExecuteNonQuery();
            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void button4_clear_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Employee set phone_one=@phone_one where FrName=@FrName", con);
            fillcombox(comboBox2);
            CMD.Parameters.AddWithValue("@FrName", this.comboBox2.Text);
        }

        private void update_ssn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("update Employee set Ssn=@Ssn where FrName=@FrName", con);
           
            CMD.Parameters.AddWithValue("@FrName", this.comboBox2.Text);
            CMD.Parameters.AddWithValue("@Ssn", textBox1.Text);

            MessageBox.Show("updated sussessful");
            con.Close();
        }

        private void CV_label_Click_1(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
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

        private void button2_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
