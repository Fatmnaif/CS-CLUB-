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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }
        public static int watings = 0;
       
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T9CKLNLO;Initial Catalog=CS_CLUB;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                watings = 1;

                if (watings == 1)
                {

                    con.Open();
                    SqlCommand c = con.CreateCommand();

                    c.CommandType = CommandType.Text;

                    c.CommandText = "insert into CS_ME values  ('" + textBox2.Text + "','" + textBox1.Text + "') ";

                    c.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Done , The user will be deleted from the waiting list once you sign out from the system ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    //---------------------------------------------
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM watingstate where username = @username and Event_code = @Event_code", con);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Event_code", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    int noa = 1;
                    con.Open();
                    cmd = new SqlCommand("UPDATE CS_AE SET CS_AE.NOA = (CS_AE.NOA - @noa) FROM CS_AE  WHERE CS_AE.Event_code = @Event_code", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@noa", SqlDbType.Int).Value = noa;
                    cmd.Parameters.Add("@Event_code", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        private void change_password_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE SignDB2 SET password1 = @t where username1= '" + Username.Text+"'", con);

                cmd.Parameters.Add("@t", password2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
         

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminEvent1 openform = new AdminEvent1();
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
            AdminEvent1 openform = new AdminEvent1();
            openform.Show();
            Visible = false;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            Username.Text = login.username;
           // email.Text=;
            password2.Text = login.password;
            sda = new SqlDataAdapter("SELECT * FROM watingstate  ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Open();
            string x;
            SqlCommand cmd = new SqlCommand("SELECT email1 FROM SignDB2 where username1 ='" + Username.Text + "'", con);
            x = cmd.ExecuteScalar().ToString();
            con.Close();
            email2.Text = x;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void email2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
