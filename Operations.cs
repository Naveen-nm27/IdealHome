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
    }
}
