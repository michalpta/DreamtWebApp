namespace WebApp.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApp.Models.WebAppEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApp.Models.WebAppEntities context)
        {
            var members = new List<FamilyMember>()
            {
                new FamilyMember() { Name = "Michal" },
                new FamilyMember() { Name = "Kasia" },
                new FamilyMember() { Name = "Wojtek" }
            };
            context.FamilyMembers.AddOrUpdate(m => m.Name, members.ToArray());
            context.SaveChanges();
        }
    }
}
