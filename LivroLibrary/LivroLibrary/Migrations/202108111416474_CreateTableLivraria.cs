namespace LivroLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableLivraria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LivroLivrariaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantEstoque = c.Int(nullable: false),
                        Nome = c.String(),
                        Autor = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LivroLivrariaModels");
        }
    }
}
