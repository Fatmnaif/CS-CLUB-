using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_CLUB_NEW
{
    public partial class memberprofile : Form
    {  public static string username1;
        public memberprofile()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T9CKLNLO;Initial Catalog=CS_CLUB;Integrated Security=True");
        public void Disp_Data()
        {
            //Members user =new Members();
            //where (username=" +user.Username+)
            con.Open();
            string q = "select * from CS_AE";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void change_password_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE SignDB1 SET password2 = @t where Username= '" + Username.Text + "'", con);

                cmd.Parameters.Add("@t", password2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Memberevent openform = new Memberevent();
            openform.Show();
            Visible = false; 
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 openform = new Form1();
            openform.Show();
            Visible = false;
        }

        private void add_event_Click(object sender, EventArgs e)
        {
            Memberevent openform = new Memberevent();
            openform.Show();
            Visible = true;

        }

        private void memberprofile_Load(object sender, EventArgs e)
        {
           
           Username.Text = login.username;
            username1=Username.Text;
         // email2.Text=email;
            password2.Text = login.password;

       /*  sda = new SqlDataAdapter("SELECT * FROM CS_ME  ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;**/

            con.Open();
            string x;
            SqlCommand cmd = new SqlCommand("SELECT email FROM SignDB1 where username ='" + Username.Text + "'", con);
            x = cmd.ExecuteScalar().ToString();
            con.Close();
            email2.Text = x;

           sda = new SqlDataAdapter("select CS_ME.Event_code , CS_AE.Type , CS_AE.Address , CS_AE.Time , CS_AE.Description from CS_AE , CS_ME where CS_AE.Event_code = CS_ME.Event_code  ", con);
           dt = new DataTable();
           sda.Fill(dt);
          dataGridView1.DataSource = dt;



        }
    }
}
