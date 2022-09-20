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
    public partial class Registration : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            //cn = new SqlConnection(@"Data Source= SAJEEV;Initial Catalog = HMS;Integrated Security=True");
           // cn.Open();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient patient = new patient();
            patient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            try
                {
                cmd = new SqlCommand("select * from patients where nic=" + nictxt.Text + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("ptient Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into patients values(@LastName,@FirstName,@nic,@dob,@mobile1,@mobile2,@gs,@p_address,@district,@gender,@gradient,@patient_add_date)", cn);
                    cmd.Parameters.AddWithValue("@LastName", lnametxt.Text);
                    cmd.Parameters.AddWithValue("@FirstName", fnametxt.Text);
                    cmd.Parameters.AddWithValue("@nic", nictxt.Text);
                    cmd.Parameters.AddWithValue("@dob", dobtxt.Text);
                    cmd.Parameters.AddWithValue("@mobile1", mnumbertxt1.Text);
                    cmd.Parameters.AddWithValue("@mobile2", mnumbertxt2.Text);
                    cmd.Parameters.AddWithValue("@gs", gstxt.Text);
                    cmd.Parameters.AddWithValue("@p_address", paddresstxt.Text);
                    cmd.Parameters.AddWithValue("@district", distxt.Text);
                    cmd.Parameters.AddWithValue("@gender", gendercbox.Text);
                    cmd.Parameters.AddWithValue("@gradient", gartxt.Text);

                    if (reg_date_txt.Text == "")
                    {
                        DateTime now = DateTime.Now;
                        var nowdate = now.ToString();
                        cmd.Parameters.AddWithValue("@patient_add_date", nowdate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@patient_add_date", reg_date_txt.Text);
                    }
                    

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patirnt created . Enjoy the service.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textclear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter a Valid patient Data");
            }
            
        }


        void textclear()
        {
            lnametxt.Clear();
            fnametxt.Clear();
            nictxt.Clear();
            dobtxt.Clear();
            mnumbertxt1.Clear();
            mnumbertxt2.Clear();
            distxt.Clear();
            paddresstxt.Clear();
            gartxt.Clear();
            gendercbox.Text = "";
            gstxt.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gstxt_TextChanged(object sender, EventArgs e)
        {

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

        private void setting_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            setuphome setuphome = new setuphome();
            setuphome.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient patient = new patient();
            patient.Show();
        }
    }
}
