using System;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void GoToProductionBtn_Click(object sender, EventArgs e)
        {
            ProductionForm prdForm = new ProductionForm();
            prdForm.Show();
        }
    }
}
