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

    public partial class signup : Form
    {

       

        public signup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T9CKLNLO;Initial Catalog=CS_CLUB;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox2.Text != textBox3.Text)
                    MessageBox.Show("the password doesn't match the confermation ");
                else
                {
                    MessageBox.Show("succefeld sign up");
                    login openform = new login();
                    openform.Show();
                    Visible = false;

                    con.Open();

                    SqlCommand c = con.CreateCommand();

                    c.CommandType = CommandType.Text;

                    c.CommandText = "insert into SignDB1 values('" + textBox1 + "','" + textBox4 + "','" + textBox3 + "') ";

                    c.ExecuteNonQuery();

                    con.Close();

                    //  MessageBox.Show("recored inserted successfully ");
                }
            }

            }

        }
    }

