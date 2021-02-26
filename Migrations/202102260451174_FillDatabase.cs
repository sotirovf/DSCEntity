namespace DSCEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Jeans', 'M', '35', '15.00', 'Description to come') ");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('T-Shirt', 'W', '12', '8.00', 'Description to come') ");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Jacket', 'W', '15', '99.99', 'Description to come') ");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Boots', 'W', '8', '36.00', 'Description to come') ");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Boots', 'M', '10', '55.00', 'Description to come') ");
        }

        public override void Down()
        {
        }
    }
}
