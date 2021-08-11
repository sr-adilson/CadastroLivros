namespace LivroLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableBiblioteca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LivroBibliotecaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Localizacao = c.String(),
                        Disponibilidade = c.Boolean(nullable: false),
                        Nome = c.String(),
                        Autor = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LivroBibliotecaModels");
        }
    }
}
