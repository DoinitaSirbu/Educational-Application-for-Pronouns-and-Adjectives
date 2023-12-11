namespace ApEducationala4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdjectiveAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        IsCorrect = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdjectiveQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextIntrebare = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PronounAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        IsCorrect = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PronounQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextIntrebare = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PronounQuestions");
            DropTable("dbo.PronounAnswers");
            DropTable("dbo.AdjectiveQuestions");
            DropTable("dbo.AdjectiveAnswers");
        }
    }
}
