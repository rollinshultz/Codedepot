namespace codedepot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sync : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Articles", newName: "Article");
            RenameTable(name: "dbo.Comments", newName: "Comment");
            RenameTable(name: "dbo.Fora", newName: "Forum");
            RenameTable(name: "dbo.Portfolios", newName: "Portfolio");
            RenameTable(name: "dbo.Codes", newName: "Code");
            DropForeignKey("dbo.Code", "Code_snippetID", "dbo.Code");
            RenameColumn(table: "dbo.Code", name: "Code_codeSnippetID", newName: "Code_snippetID");
            RenameIndex(table: "dbo.Code", name: "IX_Code_codeSnippetID", newName: "IX_Code_snippetID");
            DropPrimaryKey("dbo.Code");
            AddColumn("dbo.Article", "date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Article", "rating", c => c.Single(nullable: false));
            AddColumn("dbo.Code", "snippetID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Code", "snippetDescription", c => c.String());
            AddColumn("dbo.Code", "snippetPath", c => c.String());
            AddColumn("dbo.Code", "rating", c => c.Single(nullable: false));
            AddPrimaryKey("dbo.Code", "snippetID");
            AddForeignKey("dbo.Code", "Code_snippetID", "dbo.Code", "snippetID");
            DropColumn("dbo.Code", "codeSnippetID");
            DropColumn("dbo.Code", "codeSnippetDescription");
            DropColumn("dbo.Code", "codeSnippetPath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Code", "codeSnippetPath", c => c.String());
            AddColumn("dbo.Code", "codeSnippetDescription", c => c.String());
            AddColumn("dbo.Code", "codeSnippetID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Code", "Code_snippetID", "dbo.Code");
            DropPrimaryKey("dbo.Code");
            DropColumn("dbo.Code", "rating");
            DropColumn("dbo.Code", "snippetPath");
            DropColumn("dbo.Code", "snippetDescription");
            DropColumn("dbo.Code", "snippetID");
            DropColumn("dbo.Article", "rating");
            DropColumn("dbo.Article", "date");
            AddPrimaryKey("dbo.Code", "codeSnippetID");
            RenameIndex(table: "dbo.Code", name: "IX_Code_snippetID", newName: "IX_Code_codeSnippetID");
            RenameColumn(table: "dbo.Code", name: "Code_snippetID", newName: "Code_codeSnippetID");
            AddForeignKey("dbo.Code", "Code_snippetID", "dbo.Code", "snippetID");
            RenameTable(name: "dbo.Code", newName: "Codes");
            RenameTable(name: "dbo.Portfolio", newName: "Portfolios");
            RenameTable(name: "dbo.Forum", newName: "Fora");
            RenameTable(name: "dbo.Comment", newName: "Comments");
            RenameTable(name: "dbo.Article", newName: "Articles");
        }
    }
}
