namespace DiyBeautyRecipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedRecipe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Recipes", "MixtureID", "dbo.Mixtures");
            DropIndex("dbo.Recipes", new[] { "MixtureID" });
            AddColumn("dbo.Recipes", "Ingredients", c => c.String());
            AddColumn("dbo.Recipes", "Instructions", c => c.String());
            DropColumn("dbo.Recipes", "MixtureID");
            DropTable("dbo.Mixtures");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Mixtures",
                c => new
                    {
                        MixtureID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MixtureID);
            
            AddColumn("dbo.Recipes", "MixtureID", c => c.Int(nullable: false));
            DropColumn("dbo.Recipes", "Instructions");
            DropColumn("dbo.Recipes", "Ingredients");
            CreateIndex("dbo.Recipes", "MixtureID");
            AddForeignKey("dbo.Recipes", "MixtureID", "dbo.Mixtures", "MixtureID", cascadeDelete: true);
        }
    }
}
