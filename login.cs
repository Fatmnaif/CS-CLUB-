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
    public partial class login : Form
    {
        public static string password;
        public static string username;
      
        public login()
        {
            InitializeComponent();
        }
       SqlConnection con = new SqlConnection("Data Source=LAPTOP-T9CKLNLO;Initial Catalog=CS_CLUB;Integrated Security=True");

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* {**/

            try
            {
                if (textBox3.Text != "" && textBox3.Text != "")
                {


                    SqlCommand cmd = new SqlCommand("select username,password from SignDB1  where username ='" + textBox1.Text + "'and password ='" + textBox3.Text + "'", con);
                    SqlDataReader reader;
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    username = textBox1.Text;
                    password = textBox3.Text;
                    if (reader.HasRows)
                    {

                        memberprofile openform = new memberprofile();
                        openform.Show();
                        Visible = false;
                       
                        con.Close();
                        reader.Close();

                    } con.Close();

                    cmd = new SqlCommand("select username1,password1 from SignDB2  where username1 ='" + textBox1.Text + "'and password1 ='" + textBox3.Text + "'", con);
                    SqlDataReader read;
                    con.Open();
                    read = cmd.ExecuteReader();
                    read.Read();
                    username = textBox1.Text;
                    password = textBox3.Text;

                    if (read.HasRows)
                    {
                        AdminProfile openform = new AdminProfile();
                        openform.Show();
                        Visible = false;
                        con.Close();
                        reader.Close();

                    }
                    
                    con.Close();

                   
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
            }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        }
        
    
       
}