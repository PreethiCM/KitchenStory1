using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace KitchenStory
{
    public class DataAccess
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["KitchenStoryDB"].ConnectionString;

        public List<FoodItem> GetAllFoodItems()
        {
            List<FoodItem> foodItems = new List<FoodItem>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM FoodItem";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        FoodItem foodItem = new FoodItem
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"])
                        };

                        foodItems.Add(foodItem);
                    }

                    reader.Close();
                }
            }

            return foodItems;
        }
    }
}
