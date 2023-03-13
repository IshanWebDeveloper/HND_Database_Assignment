using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class ProductionStaffForm : Form
    {
        private int ProducID;

        private int NoOfProductionDays;
        public ProductionStaffForm()
        {
            InitializeComponent();
        }

        public ProductionStaffForm(int productionId)
        {
            InitializeComponent();
            this.ProducID = productionId;
            loadProductionStaffDetails();
        }

        private void loadProductionStaffDetails()
        {
            try
            {
                GlobalDatabaseCon.IntitializeDBCon();
                SqlCommand staffQuery = new SqlCommand("SELECT ProductionID, staff_type, number_of_employees, fee_per_production_day, number_of_days FROM production_staff ps inner join staff_type st ON ps.Staff_Type = st.staff_type_ID inner join productions p on p.Production_ID = ps.ProductionID where Production_ID=@PrdID;", GlobalDatabaseCon.GetConObj());
                staffQuery.Parameters.AddWithValue("@PrdID", ProducID);
                SqlDataReader reader = staffQuery.ExecuteReader();
                if (reader.Read())
                {
                    NoOfProductionDays = (int)reader[4];
                }
                reader.Close();

                FillDataGridView(staffQuery, dataGridView1);
                GlobalDatabaseCon.CloseDBCon();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void FillDataGridView(SqlCommand cmdQuery, DataGridView dataGridView)
        {
            try
            {
                GlobalDatabaseCon.IntitializeDBCon();
                SqlDataAdapter da = new SqlDataAdapter(cmdQuery);
                DataSet ds = new DataSet();
                DataTable dataTable = new DataTable();
                da.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
                da.Fill(dataTable);
                GlobalDatabaseCon.CloseDBCon();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ProductionStaffForm_Load(object sender, EventArgs e)
        {
            staffProducIDTxtBx.Text = ProducID.ToString();
        }

        private void calcTotalEmCompBtn_Click(object sender, EventArgs e)
        {
            try
            {

                GlobalDatabaseCon.IntitializeDBCon();
                SqlCommand calculateEmCompQuery = new SqlCommand("SELECT Production_ID, SUM(number_of_employees *(fee_per_production_day * number_of_days)) as total_employee_compensation FROM production_staff ps inner join staff_type st ON ps.Staff_Type = st.staff_type_ID inner join productions p on p.Production_ID = ps.ProductionID where Production_ID=@PrducID group by Production_ID", GlobalDatabaseCon.GetConObj());
                calculateEmCompQuery.Parameters.AddWithValue("@PrducID", ProducID.ToString());
                FillDataGridView(calculateEmCompQuery, dataGridView2);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
