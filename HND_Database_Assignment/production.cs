using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class ProductionForm : Form

    {
        private int ProdID { get; set; }
        public int TotalProductionDays { get; set; }

        public ProductionForm()
        {
            InitializeComponent();

        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void load_production()
        {
            try
            {
                GlobalDatabaseCon.intitializeDBCon();
                SqlCommand command = new SqlCommand("SELECT Production_ID,  clientID, Client_Name, Production_Name, Production_Type, number_of_days FROM productions p INNER JOIN clients c on p.clientID = c.Client_ID   WHERE Production_ID=@pID", GlobalDatabaseCon.con);
                command.Parameters.AddWithValue("@pID", Convert.ToString(prdIDTextBx.Text));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ProdID = Convert.ToInt16(reader[0]);
                    addCustLink.Enabled = false;
                    editPrdBtn.Enabled = true;
                    deletePrdBtn.Enabled = true;
                    clearPrdBtn.Enabled = true;
                    clientIDTxtBx.Text = reader[1].ToString();
                    clientNameTxtBx.Text = reader[2].ToString();
                    prdNameTxtBx.Text = reader[3].ToString();
                    prdTypeTxtBx.Text = reader[4].ToString();
                    TotalProductionDays = Convert.ToInt16(reader[5]);
                    filLocationListBox(ProdID);
                    prdDaysLabel.Text = TotalProductionDays.ToString();


                    if (reader[1] == null)
                    {
                        addCustLink.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show($"No record found for Production ID: {prdIDTextBx.Text}. You can add new record.");
                    prdDaysLabel.Text = "";
                    addPrdBtn.Enabled = true;
                    addCustLink.Enabled = true;
                    editPrdBtn.Enabled = false;
                    deletePrdBtn.Enabled = false;
                    clearPrdBtn.Enabled = true;

                }
                GlobalDatabaseCon.closeDBCon();
            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void filLocationListBox(int productionID)
        {
            GlobalDatabaseCon.intitializeDBCon();
            SqlCommand locationQuery = new SqlCommand("SELECT Location_Name FROM locations WHERE productionID=@prdID", GlobalDatabaseCon.con);
            locationQuery.Parameters.AddWithValue("@prdID", productionID);
            SqlDataReader reader = locationQuery.ExecuteReader();
            locationListBx.Items.Clear();
            while (reader.Read())
            {
                string locationsName = reader.GetString(0);
                locationListBx.Items.Add(locationsName);
            }

            GlobalDatabaseCon.closeDBCon();
        }

        private void clearProductionFrm()
        {
            prdIDTextBx.Text = string.Empty;
            clientNameTxtBx.Text = string.Empty;
            prdNameTxtBx.Text = string.Empty;
            clientIDTxtBx.Text = string.Empty;
            clientIDTxtBx.Text = string.Empty;
            prdDaysLabel.Text = string.Empty;
            prdStartDate.ResetText();
            prdEndDate.ResetText();
            prdTypeTxtBx.Text = string.Empty;
            locationListBx.Items.Clear();
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

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {

        }

        private void prdIDKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.AcceptButton = null;
                load_production();

            }
        }

        private void clearPrdBtn_Click(object sender, EventArgs e)
        {
            clearProductionFrm();
        }
    }
}
