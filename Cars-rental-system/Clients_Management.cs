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
    public partial class Clients_Management : Form
    {
        public Clients_Management()
        {
            InitializeComponent();
        }
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crs;Uid=root;Pwd=;";
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
                    string selectQuery = "SELECT * FROM clients;";

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
        private void btn_add_client_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // SQL command to insert data into the "isp" table
                    string insertQuery = "INSERT INTO clients (Name,Last_Name,CIN,Tel,Email) VALUES (@Name,@Last_Name,@CIN,@Tel,@Email);";

                    // Create a MySqlCommand object and set the parameters
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name.Text);
                        command.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
                        command.Parameters.AddWithValue("@CIN", CIN.Text);
                        command.Parameters.AddWithValue("@Tel", Tel.Text);
                        command.Parameters.AddWithValue("@Email", Email.Text);


                        // Execute the query (INSERT) - use ExecuteNonQuery for INSERT
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("ISP inserted successfully!", "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void cars_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTextBoxesWithSelectedRowData();
        }

        private void UpdateTextBoxesWithSelectedRowData()
        {
            // Check if there's a selected row in the DataGridView
            if (cars_datagrid.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = cars_datagrid.SelectedRows[0];

                // Assuming you have text boxes named MarqueTextBox, TypeTextBox, ModelTextBox, CouleurTextBox, MatriculeTextBox, and PrixTextBox
                // Populate the text boxes with the data from the selected row
                Name.Text = selectedRow.Cells["Name"].Value.ToString();
                Last_Name.Text = selectedRow.Cells["Last_Name"].Value.ToString();
                CIN.Text = selectedRow.Cells["CIN"].Value.ToString();
                Tel.Text = selectedRow.Cells["Tel"].Value.ToString();
                Email.Text = selectedRow.Cells["Email"].Value.ToString();
            }
            else
            {
                // If no row is selected, clear the text boxes
                Name.Text = "";
                Last_Name.Text = "";
                CIN.Text = "";
                Tel.Text = "";
                Email.Text = "";
            }
        }

        private void btn_update_car_Click(object sender, EventArgs e)
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

                    // Update the record in the database
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string updateQuery = "UPDATE clients SET Name = @Name, Last_Name = @Last_Name, CIN = @CIN, Tel = @Tel, Email = @Email WHERE Id = @Id"; // Replace "cars" with the actual table name and "Id" with the primary key column name.
                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Name", Name.Text);
                            command.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
                            command.Parameters.AddWithValue("@CIN", CIN.Text);
                            command.Parameters.AddWithValue("@Tel", Tel.Text);
                            command.Parameters.AddWithValue("@Email", Email.Text);
                            command.Parameters.AddWithValue("@Id", recordId);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Update the data in the DataGridView
                    Name.Text = selectedRow.Cells["Name"].Value.ToString();
                    Last_Name.Text = selectedRow.Cells["Last_Name"].Value.ToString();
                    CIN.Text = selectedRow.Cells["CIN"].Value.ToString();
                    Tel.Text = selectedRow.Cells["Tel"].Value.ToString();
                    Email.Text = selectedRow.Cells["Email"].Value.ToString();

                    MessageBox.Show("Record updated successfully!", "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void btn_remove_car_Click(object sender, EventArgs e)
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
                        string deleteQuery = "DELETE FROM clients WHERE Id = @Id"; // Replace "cars" with the actual table name and "Id" with the primary key column name.
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

        private void Clients_Management_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
