using E_Commerce_MVC_Web_UI.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC_Web_UI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        { 
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore(context);
            }


            base.Seed(context);
        }
    }
}