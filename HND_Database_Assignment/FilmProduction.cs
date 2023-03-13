using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class ProductionForm : Form

    {
        private int ProdID { get; set; }
        private int ClientID { get; set; }
        private string ClientName { get; set; }
        private int LocationID { get; set; }
        private int TotalProductionDays { get; set; }


        public ProductionForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // when click on a row, full row will be selected
            dataGridView1.MultiSelect = false;


        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void loadWithClientData(int cID, string clientName)
        {
            try
            {
                ClientID = cID;
                ClientName = clientName;
                clientIDTxtBx.Text = ClientID.ToString();
                clientNameTxtBx.Text = clientName;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void Load_production(int productionID)
        {
            try
            {
                GlobalDatabaseCon.IntitializeDBCon();
                SqlCommand command = new SqlCommand("  SELECT Production_ID,  ClientID, Client_Name, Production_Name, Production_Type, Number_of_Production_Days FROM Productions p INNER JOIN Clients c on p.ClientID = c.Client_ID   WHERE Production_ID=@pID", GlobalDatabaseCon.GetConObj());
                command.Parameters.AddWithValue("@pID", Convert.ToString(productionID));
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ProdID = Convert.ToInt16(reader[0]);
                    ClientID = Convert.ToInt16(reader[1]);
                    prdIDTextBx.Select(0, prdIDTextBx.TextLength);
                    addCustLink.Enabled = false;
                    viewClientLink.Enabled = true;
                    viewStfDetailsBtn.Enabled = true;
                    editPrdBtn.Enabled = true;
                    deletePrdBtn.Enabled = true;
                    clearPrdBtn.Enabled = true;
                    clientIDTxtBx.Text = reader[1].ToString();
                    clientNameTxtBx.Text = reader[2].ToString();
                    prdNameTxtBx.Text = reader[3].ToString();
                    prdTypeTxtBx.Text = reader[4].ToString();
                    TotalProductionDays = Convert.ToInt16(reader[5]);
                    FillLocationListBox(ProdID);

                    prdDaysLabel.Text = TotalProductionDays.ToString();
                    if (reader[1] == null)
                    {

                        addCustLink.Enabled = true;
                    }

                    reader.Close();
                    FillDataGridView(command);
                }
                else
                {
                    MessageBox.Show($"No record found for Production ID: {prdIDTextBx.Text}. You can add a new record.", "NO RECORD FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProdID = productionID;
                    clearProductionFrm();
                    prdIDTextBx.Text = Convert.ToString(ProdID);
                    prdIDTextBx.Select(0, prdIDTextBx.TextLength);
                    prdDaysLabel.Text = "";
                    viewClientLink.Enabled = false;
                    addCustLink.Enabled = true;
                    editPrdBtn.Enabled = false;
                    deletePrdBtn.Enabled = false;
                    clearPrdBtn.Enabled = true;


                }

            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                GlobalDatabaseCon.CloseDBCon();


            }

        }


        private void FillDataGridView(SqlCommand cmdQuery)
        {
            GlobalDatabaseCon.IntitializeDBCon();
            SqlDataAdapter da = new SqlDataAdapter(cmdQuery);
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            da.Fill(dataTable);

            GlobalDatabaseCon.CloseDBCon();


        }

        private void FillLocationListBox(int productionID)
        {
            try
            {
                GlobalDatabaseCon.IntitializeDBCon();
                SqlCommand locationQuery = new SqlCommand("SELECT Location_Name, Location_ID FROM Production_Locations WHERE ProductionID=@prdID", GlobalDatabaseCon.GetConObj());
                locationQuery.Parameters.AddWithValue("@prdID", productionID);
                SqlDataReader reader = locationQuery.ExecuteReader();
                locationListBx.Items.Clear();
                while (reader.Read())
                {
                    string locationsName = reader.GetString(0);
                    LocationID = (int)(reader[1]);
                    locationListBx.Items.Add(locationsName);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { GlobalDatabaseCon.CloseDBCon(); }

        }

        public void clearProductionFrm()
        {
            prdIDTextBx.Text = string.Empty;
            prdIDTextBx.Focus();
            ClientID = 0;
            viewClientLink.Enabled = false;
            viewStfDetailsBtn.Enabled = false;
            clientNameTxtBx.Text = string.Empty;
            prdNameTxtBx.Text = string.Empty;
            clientIDTxtBx.Text = string.Empty;
            clientIDTxtBx.Text = string.Empty;
            prdDaysLabel.Text = string.Empty;
            prdStartDate.ResetText();

            prdTypeTxtBx.Text = string.Empty;
            locationListBx.Items.Clear();
            dataGridView1.DataSource = null;
        }


        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientID > 0)
            {
                ClientForm clientForm = new ClientForm(ClientID, this);
                clientForm.Show();

            }
            else
            {
                ClientForm clF = new ClientForm();
                clF.Show();
            }
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
            ProductionLocationForm prodLocationForm = new ProductionLocationForm(ProdID);
            prodLocationForm.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();

        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void prdIDKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    e.SuppressKeyPress = true;
                    this.AcceptButton = null;
                    Load_production(Convert.ToInt16(prdIDTextBx.Text));

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"{ex.Message}. Please enter only numbers!", "WRONG INPUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void clearPrdBtn_Click(object sender, EventArgs e)
        {
            clearProductionFrm();
        }

        private void viewClientLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientForm clientForm = new ClientForm(ClientID, this);
            clientForm.Show();
        }

        private void viewStfDetailsBtn_Click(object sender, EventArgs e)
        {
            ProductionStaffForm prdStaff = new ProductionStaffForm(ProdID);
            prdStaff.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
