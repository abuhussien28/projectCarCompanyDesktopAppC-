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
    public partial class view_supply : Form
    {
        public view_supply()
        {
            InitializeComponent();
        }

        private void view_supply_Load(object sender, EventArgs e)
        {
            view();
        }
        private void view()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-REGMQJ5;Initial Catalog=car_company;Integrated Security=True");
            // string brancHE_name = "id_employee" + " id_branche";
            con.Open();
            String query = "select name ,name_type from Supplier S,supply_type st,type_car t  where S.id_supplier=st.supply_id and st.supply_id_type= t.id_type";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
