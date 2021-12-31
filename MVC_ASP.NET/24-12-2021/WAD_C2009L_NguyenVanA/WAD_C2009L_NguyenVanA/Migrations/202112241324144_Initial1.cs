namespace WAD_C2009L_NguyenVanA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "StudentClass", c => c.String(nullable: false));
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String());
            AlterColumn("dbo.Students", "StudentClass", c => c.String());
            AlterColumn("dbo.Students", "StudentName", c => c.String());
        }
    }
}
