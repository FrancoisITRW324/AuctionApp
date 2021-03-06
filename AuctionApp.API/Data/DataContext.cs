using AuctionApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Values> Values {get; set;}

        public DbSet<User> Users { get; set; }
     
    }
}