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

        // Full constructor (with rate, image, status, etc.)
        public Home(
           // string propertyId,
            int ownerId,
            string title,
            string address,
            int price,
           // int rate,
            string description,
            string imagePath,
           // string status,
            string sellOrRent)
        {


            if (ownerId <= 0)
                throw new ArgumentException("Owner ID must be a positive number.");

            if (string.IsNullOrWhiteSpace(title) || title.Length < 3)
                throw new ArgumentException("Title must be at least 3 characters.");

            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");


            if (string.IsNullOrWhiteSpace(imagePath) || !IsValidImagePath(imagePath))
                throw new ArgumentException("Invalid image path. Please provide a valid image.");

            // Assign values
           // PropertyId = propertyId;
            OwnerId = ownerId;
            Title = title;
            Address = address;
            Price = price;
           // Rate = rate;
            Description = description;
            ImagePath = imagePath;
           // Status = status;
            SellOrRent = sellOrRent;

            Created = DateTime.Now;
            Updated = DateTime.Now;
        }



        // Validate image file path (checking extension)
        private bool IsValidImagePath(string path)
        {
            string extension = Path.GetExtension(path).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp";
        }

        // Method to safely update the model
        public void Update(string title, string address, int price, int rate, string description, string imagePath, string status, string sellOrRent)
        {
            if (!string.IsNullOrWhiteSpace(title)) Title = title;
            Address = address;
            Price = price;
            Rate = rate;
            Description = description;
            ImagePath = imagePath;
            Status = status;
            SellOrRent = sellOrRent;

            Updated = DateTime.Now;
        }
    }
}
