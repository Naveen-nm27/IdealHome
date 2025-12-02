using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealHome
{
    internal class Home
    {
            public string PropertyId { get; private set; }
            public int OwnerId { get; private set; }
            public string Title { get; private set; }
            public string Address { get; private set; }
            public int Price { get; private set; }
            public int Rate { get; private set; }
            public string Description { get; private set; }
            public string ImagePath { get; private set; }
            public string Status { get; private set; }
            public string SellOrRent { get; private set; }
            public DateTime Created { get; private set; }
            public DateTime Updated { get; private set; }

            public Home(
                string propertyId,
                int ownerId,
                string title,
                string address,
                int price,
                int rate,
                string description,
                string imagePath,
                string status,
                string sellOrRent)
            {
                // 🔒 Validations
                if (string.IsNullOrWhiteSpace(propertyId))
                    throw new ArgumentException("Property ID is required.");

                if (ownerId <= 0)  // Added validation for ownerId
                    throw new ArgumentException("Owner ID must be a positive number.");

            if (string.IsNullOrWhiteSpace(title) || title.Length < 3)
                    throw new ArgumentException("Title must be at least 3 characters.");

                if (price < 0)
                    throw new ArgumentException("Price cannot be negative.");

                if (rate < 0 || rate > 100)
                    throw new ArgumentException("Rate must be between 0 and 100.");

                // 🔒 Assign values
                PropertyId = propertyId;
                OwnerId = ownerId;
                Title = title;
                Address = address;
                Price = price;
                Rate = rate;
                Description = description;
                ImagePath = imagePath;
                Status = status;
                SellOrRent = sellOrRent;

                // 📅 Auto timestamps
                Created = DateTime.Now;
                Updated = DateTime.Now;
            }

            // Method to safely update the model
            public void Update(
                string title,
                string address,
                int price,
                int rate,
                string description,
                string imagePath,
                string status,
                string sellOrRent)
            {
                if (!string.IsNullOrWhiteSpace(title))
                Title = title;
                Address = address;
                Price = price;
                Rate = rate;
                Description = description;
                ImagePath = imagePath;
                Status = status;
                SellOrRent = sellOrRent;

                Updated = DateTime.Now;
            }

            public Home(
                string title,
                string address,
                int price,
                string description,
                string sellOrRent
                )  // Added ownerId parameter
            {
                // 🔒 Validations
                if (string.IsNullOrWhiteSpace(title) || title.Length < 3)
                    throw new ArgumentException("Title must be at least 3 characters.");

                if (string.IsNullOrWhiteSpace(address) || address.Length < 3)
                    throw new ArgumentException("Location must be at least 3 characters.");

                if (price < 0)
                    throw new ArgumentException("Price cannot be negative.");

                if (string.IsNullOrWhiteSpace(description))
                    throw new ArgumentException("Description is required.");

                if (string.IsNullOrWhiteSpace(sellOrRent))
                    throw new ArgumentException("SellOrRent is required.");

                Title = title;
                Address = address;
                Price = price;
                Rate = 0;                   // Default rate
                Description = description;
                ImagePath = string.Empty;   // Default empty
                Status = "Available";       // Default status
                SellOrRent = sellOrRent;
                         // Set ownerId

                // 📅 Auto timestamps
                Created = DateTime.Now;
                Updated = DateTime.Now;
            }
    }

    }
