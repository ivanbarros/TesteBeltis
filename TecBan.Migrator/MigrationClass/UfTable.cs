using FluentMigrator;
using TecBan.Migrator.MigratorConfig;

namespace TecBan.Migrator.MigrationClass
{
    [Migration(130820202050)]
    public class UfTable : Migration
    {
        public override void Down()
        {
            Delete.Table("uf");
        }

        public override void Up()
        {
            Create.Table("uf")
            .CreateBaseNoCreateDate()
            .WithColumn("ufNome")
            .AsString(50)
            .NotNullable()
            .Unique();
        }
    }
}
