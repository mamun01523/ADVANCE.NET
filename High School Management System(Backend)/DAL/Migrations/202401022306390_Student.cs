namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Teachers", "Password", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
