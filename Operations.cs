using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IdealHome
{
    internal class Operations
    {
        DbConnect connection = new DbConnect();

        public bool checkConnection()
        {
            try
            {
                var conn = connection.GetConnection();
                conn.Open();
                conn.Close();
                return true;
            } catch (Exception) 
            {
                return false;
            }
        }

        public bool addHome(Home home)
        {
            var sql = @"
                INSERT INTO properties(
                    Title, 
                    Address, 
                    Price, 
                    Description, 
                    forRentOrSale
                ) VALUES (
                    @Title, 
                    @Address, 
                    @Price, 
                    @Description, 
                    @SellOrRent
                )";
            using (var con = connection.GetConnection())
            {
                con.Open();
                using (var command = new MySqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Title", home.Title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Address", home.Address ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Price", home.Price);
                    command.Parameters.AddWithValue("@Description", home.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SellOrRent", home.SellOrRent ?? (object)DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool AddImagesForProperty(int propertyId, List<string> imagePaths)
        {
            string sql = @"
        INSERT INTO property_images (PropertyID, ImagePath, IsPrimary)
        VALUES (@PropertyID, @ImagePath, 0)";

            using (var con = connection.GetConnection())
            {
                con.Open();

                foreach (string path in imagePaths)
                {
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@PropertyID", propertyId);
                        cmd.Parameters.AddWithValue("@ImagePath", path);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            return true;
        }

        public List<string> PreviewAndLoadImages(int propertyId)
        {
            // Ask user
            DialogResult dr = MessageBox.Show(
                "Images added successfully.\nDo you want to preview them?",
                "Preview Images",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (dr != DialogResult.OK)
                return null; // User pressed cancel

            // Fetch all images for this property from DB
            List<string> images = new List<string>();

            string sql = "SELECT ImagePath FROM property_images WHERE PropertyID = @PropertyID";

            using (var con = connection.GetConnection())
            {
                con.Open();

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@PropertyID", propertyId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            images.Add(reader.GetString("ImagePath"));
                        }
                    }
                }
            }

            return images;
        }


    }
}
