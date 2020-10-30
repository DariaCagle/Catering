using Catering.Data.Models;
using System.Data.Entity;

namespace Catering.Data
{
    public class CateringContext : DbContext
    {
        public CateringContext() : base("Data Source=.; Initial Catalog = Catering; Integrated Security = true") { }

        public CateringContext(string connectionString) : base(connectionString)
        { }

        public DbSet<CateringOrder> CateringOrders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Chef> Chefs { get; set; }
    }
}
