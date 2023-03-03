using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public partial class ClientForm : Form
    {
        private int ClientID { get; set; }


        public ClientForm()
        {
            InitializeComponent();
        }
        public ClientForm(int clientID)
        {
            InitializeComponent();
            ClientID = clientID;
            if (clientID > 0)
            {
                clientIDTxtBx.Text = Convert.ToString(clientID);

            }
            else
            {
                clientIDTxtBx.Text = string.Empty;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            closeProgramToolStripMenuItem.Text = $"Close {this.Text}";
            LoadClientForm();

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

        private void LoadClientForm()
        {
            if (ClientID > 0)
            {
                try
                {
                    GlobalDatabaseCon.IntitializeDBCon();
                    SqlCommand clientQuery = new SqlCommand("SELECT * FROM clients WHERE Client_ID=@cliID", GlobalDatabaseCon.GetConObj());
                    SqlCommand clientProductionQuery = new SqlCommand("SELECT Client_ID, Production_ID, Production_Name FROM clients c inner join productions p on c.Client_ID= p.clientID where Client_ID=@clientID", GlobalDatabaseCon.GetConObj());
                    clientQuery.Parameters.AddWithValue("@cliID", ClientID);
                    clientProductionQuery.Parameters.AddWithValue("@clientID", ClientID);
                    SqlDataReader reader = clientQuery.ExecuteReader();
                    if (reader.Read())
                    {
                        clientIDTxtBx.Text = Convert.ToString(ClientID);
                        clientNameTxtBx.Text = reader[1].ToString();
                        clientLocationTxtBx.Text = reader[2].ToString();
                        clientCoNumberTxtBx.Text = reader[3].ToString();

                        reader.Close();
                        FillDataGridView(clientProductionQuery);
                    }
                    else
                    {
                        MessageBox.Show($"No record found for Client ID {ClientID}", "NO RECORD FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally { GlobalDatabaseCon.CloseDBCon(); }
            }
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void clientIDTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.AcceptButton = null;
                ClientID = Convert.ToInt16(clientIDTxtBx.Text);

                LoadClientForm();


            }
        }

        private void clientIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
