using Microsoft.EntityFrameworkCore.Migrations;

namespace LibApp.Data.Migrations
{
    public partial class SetNameOfGenrese : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Thlirer')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Romance')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (5, 'SciFi')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (6, 'Fantasy')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (7, 'Raport')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
