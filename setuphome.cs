using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Early_Intervention_of_childhood
{
    public partial class setuphome : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public setuphome()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeselector homeselector=new homeselector();
            homeselector.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (diacrtxt.Text != "")
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }

                try
                {
                    cmd = new SqlCommand("insert into diagnosislist values(@dlist_name)", cn);
                    cmd.Parameters.AddWithValue("@dlist_name", diacrtxt.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Dianosis added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("some issue in Dianosis added");
                }
            }
            else
            {
                MessageBox.Show("please select Dianosis details");
            }
        }

        private void setuphome_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            //cn = new SqlConnection(@"Data Source= SAJEEV;Initial Catalog = HMS;Integrated Security=True");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sercrtxt.Text != "")
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }

                try
                {
                    cmd = new SqlCommand("insert into servicelist values(@servicelist_name)", cn);
                    cmd.Parameters.AddWithValue("@servicelist_name", sercrtxt.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New service added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("some issue in service added");
                }
            }
            else
            {
                MessageBox.Show("please select service details");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (paycretxt.Text != "")
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }

                try
                {
                    cmd = new SqlCommand("insert into paymentlist values(@paymentlist_name)", cn);
                    cmd.Parameters.AddWithValue("@paymentlist_name", paycretxt.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New service added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("some issue in paymentname added");
                }
            }
            else
            {
                MessageBox.Show("please select paymentname details");
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeselector homeselector = new homeselector();
            homeselector.Show();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
