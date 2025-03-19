using Microsoft.EntityFrameworkCore;
using CustomerManagementAPI.Models;

namespace CustomerManagementAPI.Data
{
    public class CustomerManagementContext : DbContext
    {
        public CustomerManagementContext(DbContextOptions<CustomerManagementContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
