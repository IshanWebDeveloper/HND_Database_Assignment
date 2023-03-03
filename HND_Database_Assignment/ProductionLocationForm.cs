using System;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class ProductionLocationForm : Form
    {
        public ProductionLocationForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProductionLocationForm_Load(object sender, EventArgs e)
        {

        }



        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductionPropertiesForm prdProp = new ProductionPropertiesForm();
            prdProp.Show();
        }
    }
}
