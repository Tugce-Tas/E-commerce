﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC_Web_UI.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
        
        public ApplicationRole()
        {
        }
        public ApplicationRole(string rolename, string description)
        {
            this.Description = description;
        }

    }
}