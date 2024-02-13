using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Webapp.Models
{
    public class ServicesContext : DbContext
    {
        public DbSet<UsersModel> user { get; set; }
    }
}