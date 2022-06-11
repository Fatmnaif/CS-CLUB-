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
    public partial class Memberevent : Form
    {
        public Memberevent()
        {
            InitializeComponent();
        }

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T9CKLNLO;Initial Catalog=CS_CLUB;Integrated Security=True");
        private void Memberevent_Load(object sender, EventArgs e)
        {
            try
            {
                sda = new SqlDataAdapter(@"SELECT  Event_code ,Type, Address, Time, Description, NOA FROM CS_AE", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            memberprofile openform = new memberprofile();
            openform.Show();
            Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 openform = new Form1();
            openform.Show();
            Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string x;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Time FROM CS_AE where Event_code ='" + textBox1.Text + "'", con);
                x = cmd.ExecuteScalar().ToString();
                con.Close();



                string y;
                con.Open();
                //"select CS_ME.Event_code , CS_AE.Type , CS_AE.Address , CS_AE.Time , CS_AE.Description from CS_AE , CS_ME where CS_AE.Event_code = CS_ME.Event_code 
                SqlCommand cmd2 = new SqlCommand("select CS_AE.Time  from CS_AE , CS_ME where CS_AE.Event_code = CS_ME.Event_code and CS_ME.username = '"+login.username+"'", con);
                y = cmd2.ExecuteScalar().ToString();
                con.Close();
                


                if (x != y)
                {
                    con.Open();
                    SqlCommand c = con.CreateCommand();

                    c.CommandType = CommandType.Text;

                    c.CommandText = "insert into watingstate values('" + textBox1.Text + "','" + memberprofile.username1 + "','" + AdminProfile.watings + "') ";

                    c.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("You are in the wating list ,please wait for the admin until he accept you", "WAIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sorry , you can not regester in this event because there is Some conflict between others event ");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            
          }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}
