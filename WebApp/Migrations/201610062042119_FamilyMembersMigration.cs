namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FamilyMembersMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FamilyMembers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FamilyMembers");
        }
    }
}
