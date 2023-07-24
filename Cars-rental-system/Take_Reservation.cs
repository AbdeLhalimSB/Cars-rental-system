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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cars_rental_system
{
    public partial class Take_Reservation : Form
    {
        public Take_Reservation()
        {
            InitializeComponent();
        }
        string car_id = "";
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crs;Uid=root;Pwd=;";

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Take_Reservation_Load(object sender, EventArgs e)
        {
            FillMarqueComboBox();
        }

        private void FillMarqueComboBox()
        {
            try
            {
                Cars.Items.Clear(); // Clear the ComboBox to ensure a fresh fill

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // SQL command to retrieve 'Marque' values from the 'cars' table not present in 'Car_id' column of 'reservation' table
                    string selectQuery = "SELECT DISTINCT c.Marque FROM cars c LEFT JOIN reservation r ON c.id = r.Car_id WHERE r.Car_id IS NULL";

                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if any data is available
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Add each 'Marque' value to the ComboBox
                                    string marqueValue = reader.GetString("Marque");
                                    Cars.Items.Add(marqueValue);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarDetailsByMarque(string selectedMarque)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedMarque))
                {
                    // Handle if no item is selected or the selected item is not a string
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // SQL command to retrieve all columns for the selected 'Marque'
                    string selectQuery = "SELECT * FROM cars WHERE Marque = @Marque";

                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Marque", selectedMarque);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if any data is available
                            if (reader.HasRows)
                            {
                                // Since we expect only one row, we can use the Read method once.
                                reader.Read();

                                // Get the values of other columns and update the labels accordingly
                                car_id = reader.GetString("id");
                                string type = reader.GetString("Type");
                                string model = reader.GetString("Model");
                                string couleur = reader.GetString("Couleur");
                                string matricule = reader.GetString("Matricule");
                                string prix = reader.GetString("Prix");

                                Type.Text = type;
                                Model.Text = model;
                                Couleur.Text = couleur;
                                Matricule.Text = matricule;
                                Prix.Text = prix;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMarque = Cars.SelectedItem as string;
            LoadCarDetailsByMarque(selectedMarque);
        }

        private void btn_confirme_Click(object sender, EventArgs e)
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

                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // SQL command to insert data into the "isp" table
                    string insertQuery = "INSERT INTO reservation (Name,Last_Name,CIN,Tel,Email,Permis_conduire,From_Date,To_Date,Car_id) VALUES (@Name,@Last_Name,@CIN,@Tel,@Email,@Permis_conduire,@From_Date,@To_Date,@Car_id);";

                    // Create a MySqlCommand object and set the parameters
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name.Text);
                        command.Parameters.AddWithValue("@Last_Name", Last_Name.Text);
                        command.Parameters.AddWithValue("@CIN", CIN.Text);
                        command.Parameters.AddWithValue("@Tel", Tel.Text);
                        command.Parameters.AddWithValue("@Email", Email.Text);
                        command.Parameters.AddWithValue("@Permis_conduire", Permis.Text);
                        command.Parameters.AddWithValue("@From_Date", From.Text);
                        command.Parameters.AddWithValue("@To_Date", To.Text);
                        command.Parameters.AddWithValue("@Car_id", Convert.ToInt32(car_id));

                        // Execute the query (INSERT) - use ExecuteNonQuery for INSERT
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Reservation inserted successfully!", "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Action Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Name.Text = "";
            Last_Name.Text= "";
            CIN.Text = "";
            Tel.Text = "";
            Email.Text = "";
            From.Text= "";
            To.Text = "";
        }
    }
}
