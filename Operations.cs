using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            VALUES (@PropertyID, @ImagePath, 0)"; // Default IsPrimary = 0

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


        private int offset = 0;
        
        public Dictionary<string, string>[] GetNext3Properties()
        {
            int num = GetPropertiesCount();
            Dictionary<string, string>[] result = new Dictionary<string, string>[3];

            string sql = @"
                    SELECT 
                        p.Title,
                        p.PropertyID,
                        p.Address, 
                        p.Price, 
                        p.Description, 
                        p.forRentOrSale,
                        (
                            SELECT pi.ImagePath
                            FROM property_images pi
                            WHERE pi.PropertyID = p.PropertyID
                            ORDER BY pi.ImageID ASC
                            LIMIT 1
                        ) AS ImagePath
                    FROM properties p
                    ORDER BY p.PropertyID ASC
                    LIMIT 3 OFFSET @offset;
                ";

            using (var con = connection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);

                    using (var reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            result[i] = new Dictionary<string, string>();

                            result[i]["PropertyID"] = reader["Title"].ToString();
                            result[i]["Title"] = reader["Title"].ToString();
                            result[i]["Address"] = reader["Address"].ToString();
                            result[i]["Price"] = reader["Price"].ToString();
                            result[i]["Description"] = reader["Description"].ToString();
                            result[i]["forRentOrSale"] = reader["forRentOrSale"].ToString();

                            // NEW: image path
                            result[i]["ImagePath"] =
                                reader["ImagePath"] == DBNull.Value
                                ? ""
                                : reader["ImagePath"].ToString();

                            i++;
                        }

                        

                        // if less than 3 rows, restart from beginning
                        if (i < 3)
                        {
                            offset = 0;
                            return GetNext3Properties();
                        }
                    }
                }
            }

            offset += 3;
            return result;

        }

        public int GetPropertiesCount()
        {
            string sql = "SELECT COUNT(*) FROM properties;";

            using (var con = connection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public List<Dictionary<string, string>> GetAllProperties()
        {
            var list = new List<Dictionary<string, string>>();

            string sql = @"
                        SELECT 
                            p.PropertyID,
                            p.Title,
                            p.Address,
                            p.Price,
                            p.Description,
                            p.forRentOrSale,
                            (
                                SELECT pi.ImagePath
                                FROM property_images pi
                                WHERE pi.PropertyID = p.PropertyID
                                ORDER BY pi.ImageID ASC
                                LIMIT 1
                            ) AS ImagePath
                        FROM properties p
                        ORDER BY p.PropertyID ASC;
                    ";

            using (var con = connection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new Dictionary<string, string>();
                        item["PropertyID"] = reader["PropertyID"].ToString();
                        item["Title"] = reader["Title"].ToString();
                        item["Address"] = reader["Address"].ToString();
                        item["Price"] = reader["Price"].ToString();
                        item["Description"] = reader["Description"].ToString();
                        item["forRentOrSale"] = reader["forRentOrSale"].ToString();
                        item["ImagePath"] = reader["ImagePath"] == DBNull.Value ? "" : reader["ImagePath"].ToString();

                        list.Add(item);
                    }
                }
            }

            return list;
        }

        public List<Dictionary<string, string>> GetAllPropertiesByUserId(int userId)
        {
            var list = new List<Dictionary<string, string>>();

            string sql = @"
                        SELECT
                            p.OwnerID,
                            p.PropertyID,
                            p.Title,
                            p.Address,
                            p.Price,
                            p.Description,
                            p.forRentOrSale,
                            (
                                SELECT pi.ImagePath
                                FROM property_images pi
                                WHERE pi.PropertyID = p.PropertyID
                                ORDER BY pi.ImageID ASC
                                LIMIT 1
                            ) AS ImagePath
                        FROM properties p
                        WHERE p.OwnerID = @userId
                        ORDER BY p.PropertyID ASC;
                    ";

            using (var con = connection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new Dictionary<string, string>();

                            item["OwnerID"] = reader["OwnerID"].ToString();
                            item["PropertyID"] = reader["PropertyID"].ToString();
                            item["Title"] = reader["Title"].ToString();
                            item["Address"] = reader["Address"].ToString();
                            item["Price"] = reader["Price"].ToString();
                            item["Description"] = reader["Description"].ToString();
                            item["forRentOrSale"] = reader["forRentOrSale"].ToString();
                            item["ImagePath"] =
                                reader["ImagePath"] == DBNull.Value ? "" : reader["ImagePath"].ToString();

                            list.Add(item);
                        }
                    }
                }
            }

            return list;
        }

        public (int? UserID, string UserType) Login(string username, string password)
        {
            string sql = "SELECT UserID, UserType FROM users WHERE Username = @Username AND PasswordHash = @Password";

            using (var con = connection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["UserID"]);
                            string userType = reader["UserType"].ToString();
                            return (userId, userType);
                        }
                    }
                }
            }

            return (null, null);
        }

        public (string fname,string lname) selectUserName(int userID)
        {
            string userName = "";

            string sql = "SELECT FirstName,LastName FROM users WHERE UserID = @userId;";
            
            using (var con = connection.GetConnection())
            {
                con.Open();
                using(var cmd = new MySqlCommand(sql,con))
                {
                    cmd.Parameters.AddWithValue("@userId", userID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstname = reader["FirstName"].ToString();
                            string lastname = reader["LastName"].ToString();
                            return(firstname, lastname);
                        }
                    }
                }
            }

            return (null,null);
        }

        public bool SignUp(User user)
        {
            try
            {
                // Start a transaction to ensure atomicity (everything is inserted successfully or nothing is)
                using (var con = connection.GetConnection())
                {
                    con.Open();
                    using (var transaction = con.BeginTransaction())
                    {
                        // Insert into the users table
                        string sql = @"
                    INSERT INTO users (Username, PasswordHash, FirstName, LastName, Address, Age, NIC, Gender, UserType) 
                    VALUES (@Username, @Password, @FirstName, @LastName, @Address, @Age, @NIC, @Gender, @UserType);
                    SELECT LAST_INSERT_ID();";  // Get the newly inserted UserID
                        using (var cmd = new MySqlCommand(sql, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Username", user.UserName);
                            cmd.Parameters.AddWithValue("@Password", user.Password);  // Hash the password in production!
                            cmd.Parameters.AddWithValue("@FirstName", user.FullName.Split(' ')[0]);
                            cmd.Parameters.AddWithValue("@LastName", user.FullName.Split(' ')[1]);
                            cmd.Parameters.AddWithValue("@Address", user.Location);
                            cmd.Parameters.AddWithValue("@Age", user.Age);  // Assuming Age is available
                            cmd.Parameters.AddWithValue("@NIC", user.NIC);
                            cmd.Parameters.AddWithValue("@Gender", user.Gender);
                            cmd.Parameters.AddWithValue("@UserType", user.Role);

                            // Execute and get the UserID
                            int userId = Convert.ToInt32(cmd.ExecuteScalar());

                            // Now, insert into either students or home_owners based on the user type
                            if (user.Role == "Student")
                            {
                                string studentSql = @"
                            INSERT INTO students (UserID, University, Faculty, Department)
                            VALUES (@UserID, @University, @Faculty, @Department)";
                                using (var studentCmd = new MySqlCommand(studentSql, con, transaction))
                                {
                                    studentCmd.Parameters.AddWithValue("@UserID", userId);
                                    studentCmd.Parameters.AddWithValue("@University", user.University);
                                    studentCmd.Parameters.AddWithValue("@Faculty", user.Faculty);
                                    studentCmd.Parameters.AddWithValue("@Department", user.Department);
                                    studentCmd.ExecuteNonQuery();
                                }
                            }
                            else if (user.Role == "HomeOwner")
                            {
                                string homeOwnerSql = @"
                            INSERT INTO home_owners (UserID, Area, GoogleLocation, PropertyAddress)
                            VALUES (@UserID, @Area, @GoogleLocation, @PropertyAddress)";
                                using (var homeOwnerCmd = new MySqlCommand(homeOwnerSql, con, transaction))
                                {
                                    homeOwnerCmd.Parameters.AddWithValue("@UserID", userId);
                                    homeOwnerCmd.Parameters.AddWithValue("@Area", user.Area);
                                    homeOwnerCmd.Parameters.AddWithValue("@GoogleLocation", user.GoogleLocation);
                                    homeOwnerCmd.Parameters.AddWithValue("@PropertyAddress", user.PropertyAddress);
                                    homeOwnerCmd.ExecuteNonQuery();
                                }
                            }

                            // Commit transaction if everything is fine
                            transaction.Commit();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                // Rollback if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public List<Home> SearchHomesByTitle(int userid)
        {
            List<Home> homes = new List<Home>();

            string sql = @"
                SELECT 
                    p.PropertyID,
                    p.OwnerID,
                    p.Title,
                    p.Address,
                    p.Price,
                    p.Rate,
                    p.Description,
                    pi.ImagePath,
                    p.Status,
                    p.forRentOrSale
                FROM properties p
                LEFT JOIN property_images pi ON pi.PropertyID = p.PropertyID
                WHERE p.Title = @userid;";

            using (var con = connection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                {
                    // Use LIKE for searching titles
                    cmd.Parameters.AddWithValue("@SearchTerm", userid);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Safely handle DBNull values
                            string propertyId = reader["PropertyID"] != DBNull.Value ? reader["PropertyID"].ToString() : string.Empty;
                            int ownerId = reader["OwnerID"] != DBNull.Value ? Convert.ToInt32(reader["OwnerID"]) : 0;
                            string title = reader["Title"] != DBNull.Value ? reader["Title"].ToString() : string.Empty;
                            string address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
                            int price = reader["Price"] != DBNull.Value ? Convert.ToInt32(reader["Price"]) : 0;
                            int rate = reader["Rate"] != DBNull.Value ? Convert.ToInt32(reader["Rate"]) : 0;
                            string description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : string.Empty;
                            string imagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : string.Empty;
                            string status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : string.Empty;
                            string sellOrRent = reader["SellOrRent"] != DBNull.Value ? reader["SellOrRent"].ToString() : string.Empty;

                            // Creating a Home object from the query results
                            var home = new Home(
                                ownerId,
                                title,
                                address,
                                price,
                                description,
                                imagePath,
                                sellOrRent
                            );
                            homes.Add(home); // Add the home to the list
                        }
                    }
                }
            }

            return homes; // Return the list of homes matching the title
        }


        //public bool SignUp(
        //    string firstName, string lastName, string address, int age, string nic, string gender,
        //    string username, string password, bool isStudent,
        //    string university = null, string faculty = null, string department = null,
        //    string area = null, string googleLocation = null, string propertyAddress = null)
        //{
        //    try
        //    {
        //        // Start a transaction to ensure atomicity (everything is inserted successfully or nothing is)
        //        using (var con = connection.GetConnection())
        //        {
        //            con.Open();
        //            using (var transaction = con.BeginTransaction())
        //            {
        //                // Insert into the users table
        //                string sql = @"
        //            INSERT INTO users (Username, PasswordHash, FirstName, LastName, Address, Age, NIC, Gender, UserType) 
        //            VALUES (@Username, @Password, @FirstName, @LastName, @Address, @Age, @NIC, @Gender, @UserType);
        //            SELECT LAST_INSERT_ID();";  // Get the newly inserted UserID
        //                using (var cmd = new MySqlCommand(sql, con, transaction))
        //                {
        //                    cmd.Parameters.AddWithValue("@Username", username);
        //                    cmd.Parameters.AddWithValue("@Password", password);  // Hash the password in production!
        //                    cmd.Parameters.AddWithValue("@FirstName", firstName);
        //                    cmd.Parameters.AddWithValue("@LastName", lastName);
        //                    cmd.Parameters.AddWithValue("@Address", address);
        //                    cmd.Parameters.AddWithValue("@Age", age);
        //                    cmd.Parameters.AddWithValue("@NIC", nic);
        //                    cmd.Parameters.AddWithValue("@Gender", gender);
        //                    cmd.Parameters.AddWithValue("@UserType", isStudent ? "Student" : "HomeOwner");

        //                    // Execute and get the UserID
        //                    int userId = Convert.ToInt32(cmd.ExecuteScalar());

        //                    // Now, insert into either students or home_owners based on the user type
        //                    if (isStudent)
        //                    {
        //                        string studentSql = @"
        //                    INSERT INTO students (UserID, University, Faculty, Department)
        //                    VALUES (@UserID, @University, @Faculty, @Department)";
        //                        using (var studentCmd = new MySqlCommand(studentSql, con, transaction))
        //                        {
        //                            studentCmd.Parameters.AddWithValue("@UserID", userId);
        //                            studentCmd.Parameters.AddWithValue("@University", university);
        //                            studentCmd.Parameters.AddWithValue("@Faculty", faculty);
        //                            studentCmd.Parameters.AddWithValue("@Department", department);
        //                            studentCmd.ExecuteNonQuery();
        //                        }
        //                    }
        //                    else
        //                    {
        //                        string homeOwnerSql = @"
        //                    INSERT INTO home_owners (UserID, Area, GoogleLocation, PropertyAddress)
        //                    VALUES (@UserID, @Area, @GoogleLocation, @PropertyAddress)";
        //                        using (var homeOwnerCmd = new MySqlCommand(homeOwnerSql, con, transaction))
        //                        {
        //                            homeOwnerCmd.Parameters.AddWithValue("@UserID", userId);
        //                            homeOwnerCmd.Parameters.AddWithValue("@Area", area);
        //                            homeOwnerCmd.Parameters.AddWithValue("@GoogleLocation", googleLocation);
        //                            homeOwnerCmd.Parameters.AddWithValue("@PropertyAddress", propertyAddress);
        //                            homeOwnerCmd.ExecuteNonQuery();
        //                        }
        //                    }

        //                    // Commit transaction if everything is fine
        //                    transaction.Commit();
        //                }
        //            }
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Rollback if something goes wrong
        //        MessageBox.Show("Error: " + ex.Message);
        //        return false;
        //    }
        //}





    }
}
