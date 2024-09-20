using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecute.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Cars_Id",
                table: "Cars",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_Id",
                table: "Cars");
        }
    }
}
