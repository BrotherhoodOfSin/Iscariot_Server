namespace Iscariot_server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogPass",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 128),
                        PassHash = c.String(),
                        Email = c.String(),
                        NeedAuth = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Login);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Faculty = c.String(),
                        Specialty = c.String(),
                        Section = c.String(),
                        Term = c.Int(nullable: false),
                        Monday_Ch = c.String(),
                        Monday_Z = c.String(),
                        Tuesday_Ch = c.String(),
                        Tuesday_Z = c.String(),
                        Wednesday_Ch = c.String(),
                        Wednesday_Z = c.String(),
                        Thursday_Ch = c.String(),
                        Thursday_Z = c.String(),
                        Friday_Ch = c.String(),
                        Friday_Z = c.String(),
                        Saturday_Ch = c.String(),
                        Saturday_Z = c.String(),
                        Sunday_Ch = c.String(),
                        Sunday_Z = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Spam",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(),
                        Faculty = c.String(),
                        Specialty = c.String(),
                        Section = c.String(),
                        Term = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Spam");
            DropTable("dbo.Schedule");
            DropTable("dbo.LogPass");
        }
    }
}
