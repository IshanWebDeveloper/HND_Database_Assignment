using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class ProductionLocationForm : Form
    {
        private int ProdID { get; set; }
        private int LocationID { get; set; }
        private string SelectedProdID { get; set; }
        private string SelectedLocationName { get; set; }

        public ProductionLocationForm()
        {
            InitializeComponent();
        }

        public ProductionLocationForm(int ProdID)
        {

            {
                try
                {
                    InitializeComponent();
                    this.ProdID = ProdID;
                    LoadLocationDetails();
                    FillProductionIDComboBox();
                    FillLocationNameComboBox();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void LoadLocationDetails()
        {
            GlobalDatabaseCon.IntitializeDBCon();
            //SqlCommand sqlCommand = new SqlCommand("SELECT ");
        }

        private void FillProductionIDComboBox()
        {

            GlobalDatabaseCon.IntitializeDBCon();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT productionID from locations", GlobalDatabaseCon.GetConnectionString());
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            locationPrdIDCmBoBox.DataSource = dt.Tables[0];
            locationPrdIDCmBoBox.DisplayMember = "productionID";
            locationPrdIDCmBoBox.ValueMember = "productionID";
            locationPrdIDCmBoBox.SelectedValue = this.ProdID;
            GlobalDatabaseCon.CloseDBCon();

        }

        private void FillLocationNameComboBox()
        {

            if (ProdID > 0)
            {
                GlobalDatabaseCon.IntitializeDBCon();
                SqlCommand locationNameQuery = new SqlCommand("SELECT Location_Name from locations where productionID=@prdID", GlobalDatabaseCon.GetConObj());
                locationNameQuery.Parameters.AddWithValue("@prdID", ProdID);
                SqlDataAdapter locationNameAdapter = new SqlDataAdapter(locationNameQuery);
                DataTable dataT = new DataTable();
                locationNameAdapter.Fill(dataT);
                locationNameQuery.ExecuteNonQuery();
                locationNameCmboBx.DataSource = dataT;
                locationNameCmboBx.DisplayMember = "Location_Name";
                locationNameCmboBx.ValueMember = "Location_Name";
                GlobalDatabaseCon.CloseDBCon();
            }

        }

        private void ProductionLocationForm_Load(object sender, EventArgs e)
        {

        }



        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductionPropertiesForm prdProp = new ProductionPropertiesForm();
            prdProp.Show();
        }

        private void locationNameCmboBx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedLocationName = locationNameCmboBx.SelectedValue.ToString();

        }
    }
}
