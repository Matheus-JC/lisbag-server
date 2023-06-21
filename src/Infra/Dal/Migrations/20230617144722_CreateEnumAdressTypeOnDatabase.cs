using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LisbagServer.Infra.Dal.Migrations
{
    /// <inheritdoc />
    public partial class CreateEnumAdressTypeOnDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:address_type", "commercial,residential");

            migrationBuilder.AlterColumn<int>(
                name: "type",
                schema: "profile",
                table: "address",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:address_type", "commercial,residential");

            migrationBuilder.AlterColumn<int>(
                name: "type",
                schema: "profile",
                table: "address",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
