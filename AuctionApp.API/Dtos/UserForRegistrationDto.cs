using System.ComponentModel.DataAnnotations;

namespace AuctionApp.API.Dtos
{
    public class UserForRegistrationDto
    {
        [Required]
        public string Username { get; set; }


        [Required]
        
        public  string Password { get; set; }
    }
}