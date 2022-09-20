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
    public partial class login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;


        //SqlConnection con = new SqlConnection();
        //SqlCommand cmd = new SqlCommand();

        //ConfigurationManager.ConnectionStrings["DBCS"].ToString()


        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
         
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cn.Open();
                cmd = new SqlCommand("select * from users where user_id='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    homeselector homeselector = new homeselector();
                    homeselector.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                       
        }


    }
}
