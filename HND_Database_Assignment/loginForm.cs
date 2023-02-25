using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class loginForm : Form
    {

        private string userName { get; set; }
        private string password { get; set; }

        static readonly string con_string = "Data Source=ISHAN-PC\\SQLEXPRESS;Initial Catalog=film_production;Integrated Security=true";
        SqlConnection con = new SqlConnection(con_string);
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

                }
                HomePageForm home = new HomePageForm(userName, password);
                this.Hide();
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
