using CyberSpaceApp.Models;
using CyberSpaceApp.UI_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CyberSpaceApp
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }





        private void button3_Click(object sender, EventArgs e)
        {
            ;
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void Categories_Click(object sender, EventArgs e)
        {
            Form2 categoriesForm = new Form2();
            categoriesForm.Show();
            this.Hide();
        }

        private void Games_Click(object sender, EventArgs e)
        {
            Games gamesForm = new Games();
            gamesForm.Show();


        }

        public List<SystemSpec> GetGameSpecsList()
        {
            List<SystemSpec> gameSpecsList = new List<SystemSpec>();

            try
            {
                // Connection string to SSMS Server
                string connectionString = @"Data Source=SHELBYS;Initial Catalog=CYBERRDB;Integrated Security=True;Encrypt=False;";

                // SQL query to retrieve game specifications from the database
                string query = "SELECT GameID, RAMRequirement, CPURequirement, GPURequirement, StorageRequirement FROM GameSpecsTable";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    // Read the data from the database and populate the gameSpecsList
                    while (reader.Read())
                    {
                        SystemSpec gameSpecs = new SystemSpec
                        {
                            GameID = Convert.ToInt32(reader["GameID"]),
                            RAMRequirement = Convert.ToInt32(reader["RAMRequirement"]),
                            CPURequirement = Convert.ToString(reader["CPURequirement"]),
                            GPURequirement = Convert.ToString(reader["GPURequirement"]),
                            StorageRequirement = Convert.ToString(reader["StorageRequirement"])
                        };

                        gameSpecsList.Add(gameSpecs);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or errors here (logging, displaying error message, etc.)
                Console.WriteLine("Error fetching game specifications: " + ex.Message);
            }

            return gameSpecsList;
        }

        private void List_Click(object sender, EventArgs e)
        {
            SelectGames selectForm = new SelectGames();
            selectForm.Show();







        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }



























