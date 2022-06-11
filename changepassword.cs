using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_CLUB_NEW
{
    public partial class changepassword : Form
    {
        public changepassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != textBox3.Text)
                MessageBox.Show("the password doesn't match the confermation ");
            else
            {
                
                MessageBox.Show("Done ");
                Hide();
               
                
            }
        }
    }
}
