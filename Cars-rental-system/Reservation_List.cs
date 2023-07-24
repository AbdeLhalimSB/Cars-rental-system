using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_rental_system
{
    public partial class Reservation_List : Form
    {
        public Reservation_List()
        {
            InitializeComponent();
        }
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crs;Uid=root;Pwd=;";

        private void Reservation_List_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Connection string to connect to the MySQL database

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // SQL command to select data from the "isp" table
                    string selectQuery = "SELECT * FROM reservation;";

                    // Create a DataTable to store the results
                    DataTable dataTable = new DataTable();

                    // Create a MySqlDataAdapter to fetch data from the database
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, connection))
                    {
                        // Fill the DataTable with the data from the database
                        dataAdapter.Fill(dataTable);
                    }

                    // Set the column headers in the DataGridView to be equal to the column names
                    cars_datagrid.AutoGenerateColumns = true;
                    cars_datagrid.DataSource = dataTable;

                    // Set the column auto-sizing mode to fill
                    cars_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_res_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there's a selected row in the DataGridView
                if (cars_datagrid.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = cars_datagrid.SelectedRows[0];

                    // Get the primary key or unique identifier of the record (assuming it's in the first cell)
                    int recordId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    // Perform the deletion in the database
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string deleteQuery = "DELETE FROM reservation WHERE Id = @Id"; // Replace "cars" with the actual table name and "Id" with the primary key column name.
                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Id", recordId);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Remove the row from the DataGridView
                    cars_datagrid.Rows.RemoveAt(selectedRow.Index);

                    MessageBox.Show("Record deleted successfully!", "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
