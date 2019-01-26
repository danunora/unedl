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
    public partial class Clientes : Form
    {
        String connString = @"Data Source=DANUNORA;
                            Initial Catalog=TelasPoncho;
                            Integrated Security=True;
                            Connect Timeout=30;
                            Encrypt=False;
                            TrustServerCertificate=False;
                            ApplicationIntent=ReadWrite;
                            MultiSubnetFailover=False";
        // Adding = true, Edit = false
        bool AddEdit = false;

        // Constructor
        public Clientes()
        {
            InitializeComponent();
            customerID.Text = "";
            customerDate.Text = "";
            InitFields();
        }

        // Initialize the fields as required
        private void InitFields()
        {
            textName.Clear();
            textWeb.Clear();
            textAddress.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textNotes.Clear();
        }

        // Enable/Disable buttons depending on the parameter
        private void ControlButtons(char action)
        {
            switch (action)
            {
                case 'L': // Initial, Load
                    SrcButton.Visible = true;
                    EditButton.Visible = false;
                    AddButton.Visible = true;
                    DelButton.Visible = false;
                    SaveButton.Visible = false;
                    CancelButton.Visible = false;
                    break;
                case 'B': // Search
                    SrcButton.Visible = true;
                    EditButton.Visible = false;
                    AddButton.Visible = false;
                    DelButton.Visible = false;
                    SaveButton.Visible = false;
                    CancelButton.Visible = true;
                    break;
                case 'A': // Add
                    SrcButton.Visible = false;
                    EditButton.Visible = false;
                    AddButton.Visible = false;
                    DelButton.Visible = false;
                    SaveButton.Visible = true;   
                    CancelButton.Visible = true;
                    break;
                case 'C': // Cancel
                    SrcButton.Visible = true;
                    EditButton.Visible = false;
                    AddButton.Visible = true;
                    DelButton.Visible = false;
                    SaveButton.Visible = false;
                    CancelButton.Visible = false;
                    break;
                default:   // enable all 
                    EnableFields();
                    break;
            }
        }

        /*
         * Enable fields depending on the paramater
         * by default, will enable all  
        * */
        private void EnableFields(char seleccion)
        {
            switch (seleccion)
            {
                case 'B': // Enable searching field
                    textName.Enabled = true;
                    break;
                default:   // enable all 
                    EnableFields();
                    break;
            }
        }

        // Enable the fields
        private void EnableFields()
        {
            textName.Enabled = true;
            textWeb.Enabled = true;
            textAddress.Enabled = true;
            textEmail.Enabled = true;
            textPhone.Enabled = true;
            textNotes.Enabled = true;
        }

        // Disable the fields
        private void DisableFields()
        {
            textName.Enabled = false;
            textWeb.Enabled = false;
            textAddress.Enabled = false;
            textEmail.Enabled = false;
            textPhone.Enabled = false;
            textNotes.Enabled = false;
        }

        // Loading method
        private void Clientes_Load(object sender, EventArgs e)
        {
            // Disable the fields during form loading
            DisableFields();
            ControlButtons('L');
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        // Adding 
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Initialize fields
            customerID.Text = "";
            customerDate.Text = DateTime.Now.ToString("s");

            // Enable fields for Adding
            EnableFields('A');

            // View or hide Buttons for Adding
            ControlButtons('A');

            // We are adding
            AddEdit = true;
        }

        // Searching
        private void SrcButton_Click(object sender, EventArgs e)
        {
            // Enable fields for Searching
            EnableFields('B');

            // View or hide Buttons for Searching
            ControlButtons('B');
        }

        // Cancelling
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // clean up all variables
            InitFields();

            // Disable fields 
            DisableFields();

            // View or hide Buttons for cancelling
            ControlButtons('C');

            // Initialize AddEdit action
            AddEdit = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AddEdit) // We are adding
            {
                // new instance of SQL command
                SqlCommand insertCmd;

                // insert cmd to be used
                String insertQuery = @"INSERT INTO 
                                  Customers(customerDate,
                                            customerName,
                                            customerWeb,
                                            customerAddress,
                                            customerEmail,
                                            customerPhone,
                                            customerNotes)
                                   VALUES(@customerDate,
                                          @customerName,
                                          @customerWeb,
                                          @customerAddress,
                                          @customerEmail,
                                          @customerPhone,
                                          @customerNotes)";

                // Create a new connection to the DB
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.IsAvailable())
                    {
                        try
                        {
                            // Send the insert cmd to the connection
                            insertCmd = new SqlCommand(insertQuery, conn);

                            // Read from Form and save it to the Table
                            insertCmd.Parameters.AddWithValue(@"customerDate", DateTime.Now);
                            insertCmd.Parameters.AddWithValue(@"customerName", textName);
                            insertCmd.Parameters.AddWithValue(@"customerWeb", textWeb);
                            insertCmd.Parameters.AddWithValue(@"customerAddress", textAddress);
                            insertCmd.Parameters.AddWithValue(@"customerEmail", textEmail);
                            insertCmd.Parameters.AddWithValue(@"customerPhone", textPhone);
                            insertCmd.Parameters.AddWithValue(@"customerNotes", textNotes);

                            // Execute the insert
                            insertCmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Connection to the DB not available");
                    }
                }
            }

        }
    }
}
