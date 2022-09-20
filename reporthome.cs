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
    public partial class reporthome : Form
    {
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public reporthome()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeselector homeselector =new homeselector();
            homeselector.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (reportgetcheckedListBox.Text != "")
            {
                if (reportgetcheckedListBox.Text == "Total items issue with patient")
                {
                    if (pidtxt.Text != "")
                    {
                        cmd = new SqlCommand("select * from patients inner join items on items.patient_id = patients.patient_id where items.patient_id=" + pidtxt.Text + "", cn);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        reportdataGridView.DataSource = dt;
                        cn.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from patients inner join items on items.patient_id = patients.patient_id", cn);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        reportdataGridView.DataSource = dt;
                        cn.Close();
                    }
                }


                if (reportgetcheckedListBox.Text == "Total services with patient")
                {
                    if (pidtxt.Text != "")
                    {
                        cmd = new SqlCommand("select patients.*,services.service_name,services.service_date  from patients inner join services on services.patient_id = patients.patient_id where services.patient_id=" + pidtxt.Text + "", cn);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        reportdataGridView.DataSource = dt;
                        cn.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand("select patients.*,services.service_name,services.service_date  from patients inner join services on services.patient_id = patients.patient_id", cn);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        reportdataGridView.DataSource = dt;
                        cn.Close();
                    }
                }
                //All Recorde for Out Print
                if (reportgetcheckedListBox.Text == "All Recorde for Out Print")
                {
                    if (pidtxt.Text != "")
                    {
                        cmd = new SqlCommand("SELECT patients.LastName,patients.dob,patients.district,diagnosis.diagnosis_name,services.service_name,services.service_date FROM patients JOIN diagnosis ON diagnosis.patient_id =patients.patient_id JOIN services ON services.patient_id=patients.patient_id where services.patient_id=" + pidtxt.Text + "", cn);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        reportdataGridView.DataSource = dt;
                        cn.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT patients.LastName,patients.dob,patients.district,diagnosis.diagnosis_name,services.service_name,services.service_date FROM patients JOIN diagnosis ON diagnosis.patient_id =patients.patient_id JOIN services ON services.patient_id=patients.patient_id", cn);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        reportdataGridView.DataSource = dt;
                        cn.Close();
                    }
                }







            }

            else
            {
                MessageBox.Show("Select the option .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





            
        }

        private void reporthome_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            //cn = new SqlConnection(@"Data Source= SAJEEV;Initial Catalog = HMS;Integrated Security=True");
            cn.Open();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string website = " Early Intervention of childhood";
            e.Graphics.DrawString(website, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 350, 50);

            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 100);

            string g1 = "ID ";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 80, 140);

            string g2 = "F.NAME";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 250, 140);

            string g3 = "L.NAME";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 300, 140);

            string g4 = "NIC";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 350, 140);
            string g5 = "DOB";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 400, 140);
            string g6 = "Mobile 1";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 450, 140);
            string g7 = "Mobile 2";
            e.Graphics.DrawString(g7, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 350, 140);


            string g8 = "Note";
            e.Graphics.DrawString(g8, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 500, 140);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 160);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < reportdataGridView.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= reportdataGridView.Rows.Count)
                    {

                        height += reportdataGridView.Rows[0].Height;
                        e.Graphics.DrawString(reportdataGridView.Rows[l].Cells[0].FormattedValue.ToString(), reportdataGridView.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(80, height, reportdataGridView.Columns[0].Width, reportdataGridView.Rows[0].Height));
                        e.Graphics.DrawString(reportdataGridView.Rows[l].Cells[1].FormattedValue.ToString(), reportdataGridView.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(120, height, reportdataGridView.Columns[0].Width, reportdataGridView.Rows[0].Height));
                        e.Graphics.DrawString(reportdataGridView.Rows[l].Cells[2].FormattedValue.ToString(), reportdataGridView.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(300, height, reportdataGridView.Columns[0].Width, reportdataGridView.Rows[0].Height));
                        e.Graphics.DrawString(reportdataGridView.Rows[l].Cells[3].FormattedValue.ToString(), reportdataGridView.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(350, height, reportdataGridView.Columns[0].Width, reportdataGridView.Rows[0].Height));
                        e.Graphics.DrawString(reportdataGridView.Rows[l].Cells[4].FormattedValue.ToString(), reportdataGridView.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(400, height, reportdataGridView.Columns[0].Width, reportdataGridView.Rows[0].Height));
                        e.Graphics.DrawString(reportdataGridView.Rows[l].Cells[5].FormattedValue.ToString(), reportdataGridView.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(450, height, reportdataGridView.Columns[0].Width, reportdataGridView.Rows[0].Height));
                        e.Graphics.DrawString(reportdataGridView.Rows[l].Cells[6].FormattedValue.ToString(), reportdataGridView.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(500, height, reportdataGridView.Columns[0].Width, reportdataGridView.Rows[0].Height));
                        e.Graphics.DrawString(reportdataGridView.Rows[l].Cells[7].FormattedValue.ToString(), reportdataGridView.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(550, height, reportdataGridView.Columns[0].Width, reportdataGridView.Rows[0].Height));


                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }


            }
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
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
    }
}
