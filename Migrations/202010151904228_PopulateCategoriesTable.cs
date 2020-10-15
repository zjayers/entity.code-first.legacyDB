namespace EntityFramework.CodeFirst.LegacyDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoriesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES ('Web Development')");
            Sql("INSERT INTO Categories (Name) VALUES ('Programming Languages')");
        }
        
        public override void Down()
        {
        }
    }
}
