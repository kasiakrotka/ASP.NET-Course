namespace KatarzynaKrawczykLab4Zad1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeSalaryss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Nip = c.String(nullable: false),
                        Position = c.String(nullable: false),
                        IndefinitePeriod = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        value = c.Double(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Salaries", new[] { "EmployeeId" });
            DropTable("dbo.Salaries");
            DropTable("dbo.Employees");
        }
    }
}
