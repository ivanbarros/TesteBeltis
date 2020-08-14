using FluentMigrator;
using FluentMigrator.Builders.Create.Table;

namespace TecBan.Migrator.MigratorConfig
{
    public static class CreateTableBase
    {
        public static ICreateTableWithColumnSyntax CreateBase(this ICreateTableWithColumnSyntax create, bool userFK = true)
        {
            create
                .WithColumn("Id")
                    .AsInt32()
                    .NotNullable()
                    .Identity()
                    .PrimaryKey()
                .WithColumn("atmDTCadastro")
                    .AsDateTime()
                    .NotNullable()
                    .WithDefaultValue(SystemMethods.CurrentDateTime);



            return create;
        }
        public static ICreateTableWithColumnSyntax CreateBaseNoCreateDate(this ICreateTableWithColumnSyntax create, bool userFK = true)
        {
            create
                .WithColumn("Id")
                    .AsInt32()
                    .NotNullable()
                    .Identity()
                    .PrimaryKey();
                

            return create;
        }

       
    }
}
