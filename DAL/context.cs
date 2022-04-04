using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Centric_Team_3.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Centric_Team_3.DAL
{
    public class context : DbContext
    {
        public context() : base("name=DefaultConnection")
        { 
        
        }
        public DbSet<UserDatabase> UserDatabase { get; set; }
        public DbSet<RecognitionPage> RecognitionPage { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  // note: this is all one line!
        }


    }
}