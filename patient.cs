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
    public partial class patient : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public patient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patient_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

           // cn = new SqlConnection(@"Data Source= SAJEEV;Initial Catalog = HMS;Integrated Security=True");
            cn.Open();
            cmd = new SqlCommand("select * from patients",cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeselector homeselector = new homeselector();
            homeselector.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void scarchbtn_Click(object sender, EventArgs e)
        {
            string searchValue = scarchtxt.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGridView1.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + scarchtxt.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientchange patientchange = new patientchange();
            patientchange.Show();
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
