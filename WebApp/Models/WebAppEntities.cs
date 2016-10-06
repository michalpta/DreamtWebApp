using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class WebAppEntities : DbContext
    {
        public DbSet<FamilyMember> FamilyMembers { get; set; }
    }
}