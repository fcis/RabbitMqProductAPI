using Microsoft.EntityFrameworkCore;
using RabbitMqProductAPI.Models;

namespace RabbitMqProductAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
