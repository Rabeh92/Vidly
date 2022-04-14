namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialiseGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Name) Values ('Comedy')");
            Sql("Insert into Genres (Name) Values ('Action')");
            Sql("Insert into Genres (Name) Values ('Romantic')");
        }
        
        public override void Down()
        {
            Sql("Delete From Genres");
        }
    }
}
