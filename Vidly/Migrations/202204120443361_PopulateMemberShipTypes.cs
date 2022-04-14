namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MemberShipTypes (Id,SignUpFee,DurationInMonths,DIscountRate) Values (1,0,0,0)");
            Sql("insert into MemberShipTypes (Id,SignUpFee,DurationInMonths,DIscountRate) Values (2,30,1,10)");
            Sql("insert into MemberShipTypes (Id,SignUpFee,DurationInMonths,DIscountRate) Values (3,90,3,15)");
            Sql("insert into MemberShipTypes (Id,SignUpFee,DurationInMonths,DIscountRate) Values (4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
