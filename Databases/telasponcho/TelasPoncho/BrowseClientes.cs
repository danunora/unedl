using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasPoncho
{
    public partial class BrowseClientes : Form
    {
        String connString = @"Data Source=DANUNORA;
                            Initial Catalog=TelasPoncho;
                            Integrated Security=True;
                            Connect Timeout=30;
                            Encrypt=False;
                            TrustServerCertificate=False;
                            ApplicationIntent=ReadWrite;
                            MultiSubnetFailover=False";

        // Required to build the connection between program to DB
        SqlDataAdapter dataAdapter;

        // Structure to hold the data from the DB 
        DataTable dataTable; 

        public BrowseClientes()
        {
            InitializeComponent();
        }

        private void BrowseClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * FROM customers");
        }

        private void GetData(String query)
        {
            //throw new NotImplementedException();
            try
            {
                // takes the query to the connection string
                dataAdapter = new SqlDataAdapter(query, connString);

                // make a new data table object
                dataTable = new DataTable();
                dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;

                // Fill the data table
                dataAdapter.Fill(dataTable);

                // Set the datasource to the data table
                bindingSource1.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
