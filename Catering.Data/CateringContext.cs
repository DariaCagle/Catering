using Catering.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
