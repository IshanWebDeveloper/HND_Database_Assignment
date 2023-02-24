using System;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Quiet Attic Database Managment System", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePageForm home = new HomePageForm();
            this.Hide();
            home.Show();

        }
    }
}
