using System;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class HomePageForm : Form
    {
        public string userNameH { get; set; }
        public string passwordH { get; set; }
        public HomePageForm()
        {
            InitializeComponent();
        }

        public HomePageForm(string userName, string password)
        {
            this.userNameH = userName;
            this.passwordH = password;
            InitializeComponent();

        }

        private void GoToProductionBtn_Click(object sender, EventArgs e)
        {
            ProductionForm prdForm = new ProductionForm();
            prdForm.Show();
        }

        private void goToClientBtn_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();

        }
    }
}
