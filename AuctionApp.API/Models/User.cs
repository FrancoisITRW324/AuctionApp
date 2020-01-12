namespace AuctionApp.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public int IdNumber { get; set; }

         public int PassportNumber { get; set; }

         public byte[] PasswordHash { get; set; }

         public byte[] PasswordSalt { get; set; }
    }
}