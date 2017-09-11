using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;


namespace WPF_HOME
{
    class ProductContext : DbContext
    {
        public ProductContext()
            : base("DbConnection")
        { }

        public DbSet<Product> Products { get; set; }
    }
}
