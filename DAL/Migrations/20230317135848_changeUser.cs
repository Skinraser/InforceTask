using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class changeUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urls_Users_CreatedById",
                table: "Urls");

            migrationBuilder.DropIndex(
                name: "IX_Urls_CreatedById",
                table: "Urls");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Urls_CreatedById",
                table: "Urls",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Urls_Users_CreatedById",
                table: "Urls",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
