using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Early_Intervention_of_childhood
{
    public partial class homeselector : Form
    {
        public homeselector()
        {
            InitializeComponent();
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void homeselector_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbl_date.Text = now.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient patient = new patient();
            patient.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            serviceselector serviceselector =new serviceselector();
            serviceselector.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosisselector diagnosisselector =new diagnosisselector();
            diagnosisselector.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporthome reporthome = new reporthome();
            reporthome.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            setuphome setuphome=new setuphome();    
            setuphome.Show();
        }
    }
}
