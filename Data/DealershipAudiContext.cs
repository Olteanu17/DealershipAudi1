using Microsoft.EntityFrameworkCore;
using DealershipAudi.Models;
using System.Collections.Generic;

namespace DealershipAudi.Data
{
    public class DealershipAudiContext : DbContext
    {
        public DealershipAudiContext(DbContextOptions<DealershipAudiContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
