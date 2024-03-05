using CyberSpaceApp.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CyberspaceApp.DataAccess
{
    public class DataAccess
    {
        private readonly string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method to get game specifications based on game ID
        public SystemSpec GetGameSpecs(int gameID)
        {
            SystemSpec gameSpecs = null;

            string query = "SELECT RAMRequirement, CPURequirement, GPURequirement, StorageRequirement " +
                           "FROM SystemSpecs " +
                           "WHERE GameID = @GameID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GameID", gameID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Read values from the database and populate the GameSpecs 
                            gameSpecs = new SystemSpec
                            {
                                RAMRequirement = Convert.ToInt32(reader["RAMRequirement"]),
                                CPURequirement = reader["CPURequirement"].ToString(),
                                GPURequirement = reader["GPURequirement"].ToString(),
                                StorageRequirement = reader["StorageRequirement"].ToString()
                            };
                        }
                    }
                }
            }

            return gameSpecs;
        }

        // Method to get game details based on game ID
        public GameDetails GetGameDetails(int gameId)
        {
            GameDetails gameDetails = null;

            // Implement code to fetch game details from the database using the gameId

            return gameDetails;
        }

        // Method to validate user credentials
        public bool ValidateUserCredentials(string username, string password)
        {
            int userCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("UserLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    userCount = (int)command.ExecuteScalar();
                }
            }

            return userCount > 0;
        }
    }
}














