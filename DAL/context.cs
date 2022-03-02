using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Centric_Team_3.Models;

namespace Centric_Team_3.DAL
{
    public class context : DbContext
    {
        public context() : base("name=DefaultConnection")
        { 
        
        }
        public DbSet<UserDatabase> UserDatabase { get; set; }
    }
}