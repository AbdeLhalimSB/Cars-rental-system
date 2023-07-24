using MySql.Data.MySqlClient;
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

namespace Cars_rental_system
{
    public partial class Cars_Managment : Form
    {
        public Cars_Managment()
        {
            InitializeComponent();
        }
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crs;Uid=root;Pwd=;";

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private SqlConnection connection;
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
                    string selectQuery = "SELECT * FROM cars;";

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

        private void Cars_Managment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_add_car_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // SQL command to insert data into the "isp" table
                    string insertQuery = "INSERT INTO cars (Marque,Type,Model,Couleur,Matricule,Prix) VALUES (@Marque,@Type,@Model,@Couleur,@Matricule,@Prix);";

                    // Create a MySqlCommand object and set the parameters
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Marque", Marque.Text);
                        command.Parameters.AddWithValue("@Type", Type.Text);
                        command.Parameters.AddWithValue("@Model", Model.Text);
                        command.Parameters.AddWithValue("@Couleur", Couleur.Text);
                        command.Parameters.AddWithValue("@Matricule", Matricule.Text);
                        command.Parameters.AddWithValue("@Prix", Prix.Text);


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
                        string deleteQuery = "DELETE FROM cars WHERE Id = @Id"; // Replace "cars" with the actual table name and "Id" with the primary key column name.
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

        private void cars_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                Marque.Text = selectedRow.Cells["Marque"].Value.ToString();
                Type.Text = selectedRow.Cells["Type"].Value.ToString();
                Model.Text = selectedRow.Cells["Model"].Value.ToString();
                Couleur.Text = selectedRow.Cells["Couleur"].Value.ToString();
                Matricule.Text = selectedRow.Cells["Matricule"].Value.ToString();
                Prix.Text = selectedRow.Cells["Prix"].Value.ToString();
            }
            else
            {
                // If no row is selected, clear the text boxes
                Marque.Text = "";
                Type.Text = "";
                Model.Text = "";
                Couleur.Text = "";
                Matricule.Text = "";
                Prix.Text = "";
            }
        }

        private void cars_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTextBoxesWithSelectedRowData();
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
                        string updateQuery = "UPDATE cars SET Marque = @Marque, Type = @Type, Model = @Model, Couleur = @Couleur, Matricule = @Matricule, Prix = @Prix WHERE Id = @Id"; // Replace "cars" with the actual table name and "Id" with the primary key column name.
                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Marque", Marque.Text);
                            command.Parameters.AddWithValue("@Type", Type.Text);
                            command.Parameters.AddWithValue("@Model", Model.Text);
                            command.Parameters.AddWithValue("@Couleur", Couleur.Text);
                            command.Parameters.AddWithValue("@Matricule", Matricule.Text);
                            command.Parameters.AddWithValue("@Prix", Prix.Text);
                            command.Parameters.AddWithValue("@Id", recordId);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Update the data in the DataGridView
                    selectedRow.Cells["Marque"].Value = Marque.Text;
                    selectedRow.Cells["Type"].Value = Type.Text;
                    selectedRow.Cells["Model"].Value = Model.Text;
                    selectedRow.Cells["Couleur"].Value = Couleur.Text;
                    selectedRow.Cells["Matricule"].Value = Matricule.Text;
                    selectedRow.Cells["Prix"].Value = Prix.Text;

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
        }
    }
}
