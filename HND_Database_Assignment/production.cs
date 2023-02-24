using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class ProductionForm : Form

    {
        static readonly string con_string = "Data Source=ISHAN-PC\\SQLEXPRESS;Initial Catalog=film_production;Integrated Security=true";
        SqlConnection con = new SqlConnection(con_string);

        public ProductionForm()
        {
            InitializeComponent();

        }






        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientForm addClient = new ClientForm();
            addClient.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionStaffForm prodStaff = new ProductionStaffForm();
            prodStaff.Show();
        }

        private void productionProperitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionPropertiesForm prodProp = new ProductionPropertiesForm();
            prodProp.Show();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionLocationForm prodLocationForm = new ProductionLocationForm();
            prodLocationForm.Show();
        }

        private void addLocatonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductionLocationForm prodLocationForm = new ProductionLocationForm();
            prodLocationForm.Show();
        }
    }
}
