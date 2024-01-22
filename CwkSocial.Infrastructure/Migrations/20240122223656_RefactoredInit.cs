using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CwkSocial.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RefactoredInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_UserProfiles_UserProfileId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_UserProfileId",
                table: "Comment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserProfileId",
                table: "Comment",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_UserProfiles_UserProfileId",
                table: "Comment",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
