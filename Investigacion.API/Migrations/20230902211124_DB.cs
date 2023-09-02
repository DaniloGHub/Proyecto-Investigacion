using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investigacion.API.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProyectIvents",
                table: "ProyectIvents");

            migrationBuilder.DropIndex(
                name: "IX_ProyectIvents_Name",
                table: "ProyectIvents");

            migrationBuilder.RenameTable(
                name: "ProyectIvents",
                newName: "ProyectInvents");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProyectInvents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProyectInvents",
                table: "ProyectInvents",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectInvents_Id",
                table: "ProyectInvents",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProyectInvents",
                table: "ProyectInvents");

            migrationBuilder.DropIndex(
                name: "IX_ProyectInvents_Id",
                table: "ProyectInvents");

            migrationBuilder.RenameTable(
                name: "ProyectInvents",
                newName: "ProyectIvents");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProyectIvents",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProyectIvents",
                table: "ProyectIvents",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectIvents_Name",
                table: "ProyectIvents",
                column: "Name",
                unique: true);
        }
    }
}
