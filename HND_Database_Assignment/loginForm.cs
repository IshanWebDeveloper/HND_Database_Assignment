using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class loginForm : Form
    {

        private string userName { get; set; }
        private string password { get; set; }


        public loginForm()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (userNameTxtBx.Text != null & passwordTxtBx.Text != null)
                {
                    userName = userNameTxtBx.Text;
                    password = passwordTxtBx.Text;
                    GlobalDatabaseCon.IntitializeDBCon();
                    SqlCommand cmd = new SqlCommand("", GlobalDatabaseCon.GetConObj());

                    HomePageForm home = new HomePageForm(userName, password);
                    this.Hide();
                    home.Show();
                    GlobalDatabaseCon.CloseDBCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
