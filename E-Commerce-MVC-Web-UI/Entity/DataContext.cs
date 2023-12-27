using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using E_Commerce_MVC_Web_UI.Identity;

namespace E_Commerce_MVC_Web_UI.Entity
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext() : base("dataConnection") 
        { 
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}