using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Examen_Allan_sibaja___Josue_Lopez.Models
{
    public class ContextPelicula : DbContext
    {
      
            public DbSet<Pelicula> infoBlog { get; set; }
            

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }

            public ContextPelicula() : base("DBpelicula") { }
        }
    
}