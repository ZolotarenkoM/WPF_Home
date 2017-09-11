using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace WPF_HOME
{
    class SampleContext : DbContext
    {
        public SampleContext()
            : base("ProductsDB") 
        { }
        public DbSet<Product> Products_table { get; set; }
        public DbSet<Users> Users_table { get; set; }
    }
}
