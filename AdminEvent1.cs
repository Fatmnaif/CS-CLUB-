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


    // try and catch with delete when he delete unexcuted info 
    // try and catch with delete when he delete unexcuted info 
    // try and catch with delete when he delete unexcuted info 
    // try and catch with delete when he delete unexcuted info 
    // try and catch with delete when he delete unexcuted info 

    public partial class AdminEvent1 : Form
    {
       
        public AdminEvent1()
        {
            InitializeComponent();
        }

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
      

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T9CKLNLO;Initial Catalog=CS_CLUB;Integrated Security=True");

        private void AdminEvent1_Load(object sender, EventArgs e)
        {

            sda = new SqlDataAdapter(@"SELECT  Event_code ,Type, Address, Time, Description, NOA FROM CS_AE", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                c.CommandType = CommandType.Text;
                c.CommandText = "insert into CS_AE values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done press putton show to show the new data ");
            }
            catch (Exception ex)
            { MessageBox.Show("only numbers allow in Number of Attendence , please try again"); }

        }
        //show ممكن نحذفها بعدييييننن 
        private void button2_Click(object sender, EventArgs e)
        {

            sda = new SqlDataAdapter(@"SELECT  Event_code ,Type, Address, Time, Description, NOA FROM CS_AE", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           try
           {

                sda = new SqlDataAdapter(@"DELETE FROM  CS_AE WHERE Event_code = '" + textBox1.Text+"'", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Done press putton show to show the deleted data ");

            }
            catch (Exception ex)
           { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CS_AE SET Type = @t, Address = @a, Time = @ti, Description = @d, NOA = @n where Event_code =" + textBox1.Text, con);
                //cmd.Parameters.Add("e", textBox1.Text);
                cmd.Parameters.Add("t", textBox2.Text);
                cmd.Parameters.Add("a", textBox6.Text);
                cmd.Parameters.Add("ti", textBox5.Text);
                cmd.Parameters.Add("d", textBox4.Text);
                cmd.Parameters.Add("n", textBox3.Text);
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
            AdminProfile f = new AdminProfile();
            f.Show();
            Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Visible = false;
        }
   

    }
}


