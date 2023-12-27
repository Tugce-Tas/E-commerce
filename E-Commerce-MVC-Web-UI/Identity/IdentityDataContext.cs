using E_Commerce_MVC_Web_UI.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace E_Commerce_MVC_Web_UI.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
    }
}