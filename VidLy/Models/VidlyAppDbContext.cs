using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VidLy.Models
{
    public class VidlyAppDbContext: DbContext
    {

       public DbSet<Customer> Customers { get; set; }
        //public DbSet<MemebershipType> MemebershipTypes { get; set; }
        //public DbSet<Movie> Movies { get; set; }
        //public DbSet<GenreTable> Genres { get; set; }


        
    }
}