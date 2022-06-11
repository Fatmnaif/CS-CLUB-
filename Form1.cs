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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login openform = new login();
            openform.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup openform = new signup ();
            openform.Show();
            Visible = false;
        }
    }
}
