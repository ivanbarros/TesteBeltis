using FluentMigrator;
using TecBan.Migrator.MigratorConfig;

namespace TecBan.Migrator.MigrationClass
{
    [Migration(130820202207)]
    public class AtmTable : Migration
    {
        public override void Down()
        {
            Delete.Table("ATM");
        }

        public override void Up()
        {
            Create.Table("ATM")
            .CreateBase()
            .WithColumn("atmNome")
            .AsString(50)
            .NotNullable()
            .Unique()

            .WithColumn("atmPA")
            .AsInt32()
            .NotNullable()


            .WithColumn("atmPC")
            .AsString(50)
            .NotNullable()

            .WithColumn("atmEndereco")
            .AsString(50)
            .NotNullable()

            .WithColumn("atmComplemento")
            .AsString(50)
            .Nullable()

            .WithColumn("atmBairro")
            .AsString(50)
            .NotNullable()

            .WithColumn("atmCidade")
            .AsInt32()
            .ForeignKey("municipios", "Id")
            .NotNullable()

            .WithColumn("atmUF")
            .AsInt32()
            .NotNullable()

            .WithColumn("atmCep")
            .AsString(8)
            .NotNullable()

            .WithColumn("atmPontoRef")
            .AsString(50)
            .Nullable()

            .WithColumn("atmLongitude")
            .AsInt32()
            .NotNullable()

            .WithColumn("atmLatitude")
            .AsInt32()
            .NotNullable();
        }
    }
}
