namespace ProjetoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class incial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
