using FluentMigrator;
using TecBan.Migrator.MigratorConfig;

namespace TecBan.Migrator.MigrationClass
{
    [Migration(130820202100)]
    public class MunicipioTable : Migration
    {
        public override void Down()
        {
            Delete.Table("municipios");
        }

        public override void Up()
        {
            Create.Table("municipios")
            .CreateBaseNoCreateDate()
            .WithColumn("munNome")
            .AsString(50)
            .NotNullable()
            
            .WithColumn("munUf")
            .AsInt32()
            .NotNullable()
            .ForeignKey("uf","Id")
            
            
            .WithColumn("munISS")
            .AsDecimal()
            .NotNullable()
            
            .WithColumn("munICMS")
            .AsDecimal()
            .NotNullable()

            .WithColumn("munICMSInterno")
            .AsDecimal()
            .NotNullable();
        }
    }
}
