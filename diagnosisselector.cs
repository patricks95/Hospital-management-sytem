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
    public partial class diagnosisselector : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public diagnosisselector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
            }
            

            // diagnosis find 

            cmd = new SqlCommand("select diagnosis_name, diagnosis_Analysiser from diagnosis where patient_id=" + pidtxt.Text + "", cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dfinddataGridView.DataSource = dt;
            cn.Close();


        }

        private void diagnosisselector_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

           // cn = new SqlConnection(@"Data Source= SAJEEV;Initial Catalog = HMS;Integrated Security=True");
            cn.Open();

            cmd = new SqlCommand("select * from diagnosislist", cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                diagnosisnamecbox.Items.Add(dt.Rows[i]["dlist_name"].ToString());

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeselector homeselector = new homeselector();
            homeselector.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (diagnosisnamecbox.Text != "")
            {
               
                if (cn.State != ConnectionState.Open)
                {
                  cn.Open();
                }
                    try
                    {
                    
                    cmd = new SqlCommand("insert into diagnosis values(@diagnosis_name,@diagnosis_Analysiser,@patient_id)", cn);
                    cmd.Parameters.AddWithValue("@diagnosis_name", diagnosisnamecbox.Text);
                    cmd.Parameters.AddWithValue("@diagnosis_Analysiser", diagnosisfindtxt.Text);
                    cmd.Parameters.AddWithValue("@patient_id", pidtxt.Text);

                    

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("diagnosis updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("some issue in diagnosis  added");
                }
            }
            else
            {
                MessageBox.Show("please select diagnosis details");
            }
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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
