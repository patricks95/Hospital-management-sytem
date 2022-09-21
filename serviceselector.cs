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
    public partial class serviceselector : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public serviceselector()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void serviceselector_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            //cn = new SqlConnection(@"Data Source= SAJEEV;Initial Catalog = HMS;Integrated Security=True");
            cn.Open();

            //service list load 
            cmd = new SqlCommand("select * from servicelist", cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                servicecheckedListBox.Items.Add(dt.Rows[i]["servicelist_name"].ToString());

            }

            // payment list load
            cmd = new SqlCommand("select * from paymentlist", cn);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                paymentcheckedListBox.Items.Add(dt2.Rows[i]["paymentlist_name"].ToString());

            }





        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void service_today_btn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            service_date_txt.Text = now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeselector homeselector = new homeselector();
            homeselector.Show();
        }



        public void button1_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("select * from patients where patient_id=" + pfindtxt.Text + "", cn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                // DateTime now = DateTime.Now;

                pidtxt.Text = dr["patient_id"].ToString();
                pnametxt.Text = dr["LastName"].ToString();
                pdobtxt.Text = dr["dob"].ToString();

                //age 
                var cdate = DateTime.UtcNow;
                var bdate = dr["dob"].ToString();
                var dob = DateTime.Parse(bdate);
                var age = ((cdate - dob).Days) / 365;
                // var age = cdate.Year - dob.Year;



                pagetxt.Text = age.ToString();
                paddtxt.Text = dr["p_address"].ToString();
                pgstxt.Text = dr["gs"].ToString();

            }
            else
            {
                MessageBox.Show("please Enter a valid data");
            }
            dr.Close();


            //diag

            cmd = new SqlCommand("select diagnosis_name, diagnosis_Analysiser from diagnosis where patient_id=" + pidtxt.Text + "", cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dfinddataGridView.DataSource = dt;
            cn.Close();

            // item itemdataGridView
            //cn.Open();
            cmd = new SqlCommand("select item_name, item_date from items where patient_id=" + pidtxt.Text + "", cn);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            itemdataGridView.DataSource = dt2;
            cn.Close();

            
            cmd = new SqlCommand("select service_name, service_date from services where patient_id=" + pidtxt.Text + "", cn);
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            servicedataGridView.DataSource = dt3;
            cn.Close();


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (servicecheckedListBox.Text != "")
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
               
                    try
                    {
                       // cn.Open();
                        cmd = new SqlCommand("insert into services values(@service_name,@service_date,@patient_id)", cn);
                        cmd.Parameters.AddWithValue("@service_name", servicecheckedListBox.Text);
                        cmd.Parameters.AddWithValue("@service_date", servicedatetxt.Text);
                        cmd.Parameters.AddWithValue("@patient_id", pidtxt.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Service updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dr.Close();
                        
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("some issue in service added");
                    }
            }
            else
            {
                MessageBox.Show("please select any service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

           


        }

        private void servicedatebtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            servicedatetxt.Text = now.ToString();
        }

        private void thingsupdatebtn_Click(object sender, EventArgs e)
        {
            if (itemnametxt.Text != "")
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }

                try
                    {
                        //cn.Open();
                        cmd = new SqlCommand("insert into items values(@item_name,@item_date,@item_dec,@patient_id)", cn);
                        cmd.Parameters.AddWithValue("@item_name", itemnametxt.Text);
                        cmd.Parameters.AddWithValue("@item_date", service_date_txt.Text);
                        cmd.Parameters.AddWithValue("@item_dec", dectxt.Text);
                        cmd.Parameters.AddWithValue("@patient_id", pidtxt.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("items updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dr.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("some issue in items  added");
                    }

                
                   
            }
            else
            {
                MessageBox.Show("please enter item name");

            }
            





        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            if (paymentcheckedListBox.Text != "" )
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }

                try
                    {
                       // cn.Open();
                        cmd = new SqlCommand("insert into payments values(@payment_name,@payment_amount,@payment_date,@patient_id,@payment_dec)", cn);
                        cmd.Parameters.AddWithValue("@payment_name", paymentcheckedListBox.Text);
                        cmd.Parameters.AddWithValue("@payment_amount", paymenttxts.Text);
                        cmd.Parameters.AddWithValue("@payment_date", paymentdatetxt.Text);
                        cmd.Parameters.AddWithValue("@patient_id", pidtxt.Text);
                        cmd.Parameters.AddWithValue("@payment_dec", paymentdectxt.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("payment updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dr.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("some issue in payment  added");
                    }

                
                    
            }
            else
            {
                MessageBox.Show("please select payment details");
            }
            





        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            paymentdatetxt.Text = now.ToString();
        }

        private void dfinddataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeselector homeselector = new homeselector();
            homeselector.Show();
        }
    }
}
