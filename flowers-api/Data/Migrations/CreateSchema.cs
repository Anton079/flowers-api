using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;

namespace flowers_api.Data.Migrations
{
    [Migration(02022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("user")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("type").AsString(120).NotNullable()
                .WithColumn("price").AsInt32().NotNullable()
                .WithColumn("rating").AsInt32().NotNullable();
        }
    }
}
