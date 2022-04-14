namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialiseNameColummn : DbMigration
    {
        public override void Up()
        {
            Sql("Update MemberShipTypes Set Name='Pay as You Go' where id=1");
            Sql("Update MemberShipTypes Set Name='Monthly' where id=2");
            Sql("Update MemberShipTypes Set Name='Quarterly' where id=3");
            Sql("Update MemberShipTypes Set Name='Yearly' where id=4");
        }
        
        public override void Down()
        {
            Sql("Update MemberShipTypes Set Name=null");
        }
    }
}
