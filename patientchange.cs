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
    public partial class patientchange : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public patientchange()
        {
            InitializeComponent();
        }

        private void pnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pfindtxt.Text != "")
            {
                cmd = new SqlCommand("select * from patients where patient_id=" + pfindtxt.Text + "", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // DateTime now = DateTime.Now;

                    patient_idtxt.Text = dr["patient_id"].ToString();
                    LastNametxt.Text = dr["LastName"].ToString();
                    FirstNametxt.Text = dr["FirstName"].ToString();
                    nictxt.Text = dr["nic"].ToString();
                    dobtxt.Text = dr["dob"].ToString();
                    mobile1txt.Text = dr["mobile1"].ToString();
                    mobile2txt.Text = dr["mobile2"].ToString();
                    gstxt.Text = dr["gs"].ToString();
                    districttxt.Text = dr["district"].ToString();
                    p_addresstxt.Text = dr["p_address"].ToString();
                    
                    gartxt.Text = dr["gradient"].ToString();
                    gentxt.Text = dr["gender"].ToString();

                }
                else
                {
                    MessageBox.Show("patient Not Found");
                }
                dr.Close();

            }

            else
            {
                MessageBox.Show("Enter the patient id");
            }

            

        }

        private void patientchange_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

           // cn = new SqlConnection(@"Data Source= SAJEEV;Initial Catalog = HMS;Integrated Security=True");
            cn.Open();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (patient_idtxt.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM patients WHERE patient_id=" + pfindtxt.Text + "", cn);
                        dr = cmd.ExecuteReader();
                        MessageBox.Show("Sucess To Delete");
                        cleartext();




                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    dr.Close();
                }

            }
            else
            {
                MessageBox.Show("please select patient");
            }

            
        }

        void cleartext()
        {
            pfindtxt.Clear();
            patient_idtxt.Clear();
            LastNametxt.Clear();
            FirstNametxt.Clear();
            nictxt.Clear();
            dobtxt.Clear();
            mobile1txt.Clear();
            mobile2txt.Clear();
            gstxt.Clear();
            p_addresstxt.Clear();
            districttxt.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient patient = new patient();
            patient.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (pfindtxt.Text != "") 
            {
                try
                {
                    cmd = new SqlCommand("UPDATE patients  SET FirstName = @FirstName , LastName = @LastName , nic = @nic , dob = @dob , mobile1 = @mobile1 , mobile2 = @mobile2 , gs = @gs , p_address = @p_address , district = @district , gender = @gender , gradient = @gradient  where patient_id=" + pfindtxt.Text + "", cn);

                    cmd.Parameters.AddWithValue("@LastName", LastNametxt.Text);
                    cmd.Parameters.AddWithValue("@FirstName", FirstNametxt.Text);
                    cmd.Parameters.AddWithValue("@nic", nictxt.Text);
                    cmd.Parameters.AddWithValue("@dob", dobtxt.Text);
                    cmd.Parameters.AddWithValue("@mobile1", mobile1txt.Text);
                    cmd.Parameters.AddWithValue("@mobile2", mobile2txt.Text);
                    cmd.Parameters.AddWithValue("@gs", gstxt.Text);
                    cmd.Parameters.AddWithValue("@p_address", p_addresstxt.Text);
                    cmd.Parameters.AddWithValue("@district", districttxt.Text);
                    cmd.Parameters.AddWithValue("@gender", gentxt.Text);
                    cmd.Parameters.AddWithValue("@gradient", gartxt.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("patient Updated Successfully.");
                    cn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some issue Update patients");
                }


            }
            else
            {
                MessageBox.Show("please select patients");

            }


            





        }

        private void FirstNametxt_TextChanged(object sender, EventArgs e)
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
    }
}
