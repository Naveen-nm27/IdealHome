using System.Text.RegularExpressions;

namespace IdealHome
{
    internal class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }
        public string UserImage { get; set; }

        // New properties added for User
        public int Age { get; set; }       // Age property
        public string NIC { get; set; }     // NIC property
        public string Gender { get; set; } // Gender property

        // Student properties
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }

        // HomeOwner properties
        public string Area { get; set; }
        public string GoogleLocation { get; set; }
        public string PropertyAddress { get; set; }

        // Constructor with all fields (updated)
        public User(int userId, string userName, string fullName, string password, string role,
                    string location, string userImage, int age, string nic, string gender,
                    string university = null, string faculty = null, string department = null,
                    string area = null, string googleLocation = null, string propertyAddress = null)
        {
            UserId = userId;
            UserName = userName;
            FullName = fullName;
            Password = password;
            Role = role;
            Location = location;
            UserImage = userImage;
            Age = age;        // Now we include age
            NIC = nic;        // Now we include NIC
            Gender = gender;  // Now we include Gender
            University = university;
            Faculty = faculty;
            Department = department;
            Area = area;
            GoogleLocation = googleLocation;
            PropertyAddress = propertyAddress;
        }

        // Method to validate user data before inserting into the database
        public bool Verify(out string errorMessage)
        {
            errorMessage = string.Empty;

            // Check if Username is empty
            if (string.IsNullOrWhiteSpace(UserName))
            {
                errorMessage = "Username cannot be empty.";
                return false;
            }

            // Check if Password is empty or too short
            if (string.IsNullOrWhiteSpace(Password) || Password.Length < 6)
            {
                errorMessage = "Password must be at least 6 characters long.";
                return false;
            }

            // Check if FullName is empty
            if (string.IsNullOrWhiteSpace(FullName))
            {
                errorMessage = "Full name cannot be empty.";
                return false;
            }

            // Check if Location is empty
            if (string.IsNullOrWhiteSpace(Location))
            {
                errorMessage = "Location cannot be empty.";
                return false;
            }

            // Check if Age is provided
            if (Age <= 0)
            {
                errorMessage = "Age must be a valid number.";
                return false;
            }

            // Check if NIC is provided
            if (string.IsNullOrWhiteSpace(NIC))
            {
                errorMessage = "NIC cannot be empty.";
                return false;
            }

            // Check if Gender is selected
            if (string.IsNullOrWhiteSpace(Gender))
            {
                errorMessage = "Gender cannot be empty.";
                return false;
            }

            // Check if role is selected (either Student or HomeOwner)
            if (string.IsNullOrWhiteSpace(Role))
            {
                errorMessage = "Role is required.";
                return false;
            }

            // If the user is a student, check university, faculty, department
            if (Role == "Student")
            {
                if (string.IsNullOrWhiteSpace(University) || string.IsNullOrWhiteSpace(Faculty) || string.IsNullOrWhiteSpace(Department))
                {
                    errorMessage = "Student information is incomplete (University, Faculty, and Department are required).";
                    return false;
                }
            }
            // If the user is a home owner, check the area and property information
            else if (Role == "HomeOwner")
            {
                if (string.IsNullOrWhiteSpace(Area) || string.IsNullOrWhiteSpace(PropertyAddress))
                {
                    errorMessage = "Homeowner information is incomplete (Area and Property Address are required).";
                    return false;
                }
            }

            return true; // All checks passed
        }

        // Password verification for strength (optional)
        public static bool VerifyPasswordStrength(string password)
        {
            // Basic regex to ensure the password contains at least one number, one uppercase letter, and is at least 6 characters long
            string pattern = @"^(?=.*[A-Z])(?=.*\d).{6,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
