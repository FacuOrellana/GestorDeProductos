using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Dominio;

namespace TP7.AccesoADatos
{
    public class ProductosContext: DbContext
    {
        public ProductosContext():base("name=ProductosConnection")
        {

        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();

            modelBuilder.
                Entity<Producto>().
                HasKey(p=> p.Codigo). 
                ToTable("Productos");            


            base.OnModelCreating(modelBuilder);
        }

    }
}
