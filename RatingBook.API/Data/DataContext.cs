using Microsoft.EntityFrameworkCore;
using RatingBook.API.Models;

namespace RatingBook.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext (DbContextOptions<DataContext> options) : base (options)
        {

        }

    }
}