using CrudEFCoreWithSwagger.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEFCoreWithSwagger
{
    /*DBContext class is basically used by our application to interact with the underlying database*
     Inherit DbContext class to Entities class*/
    public class Entities: DbContext  
    {

       /* To pass the DbContextOptions instance we need to use the constructor of Entities class*/
        public Entities(DbContextOptions<Entities> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
