using Microsoft.EntityFrameworkCore.Migrations;

namespace KendraMakeupArtist.Data.Migrations
{
    public partial class AddApplicationUserForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AppointmentRequests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentRequests_ApplicationUserId",
                table: "AppointmentRequests",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentRequests_AspNetUsers_ApplicationUserId",
                table: "AppointmentRequests",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentRequests_AspNetUsers_ApplicationUserId",
                table: "AppointmentRequests");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentRequests_ApplicationUserId",
                table: "AppointmentRequests");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AppointmentRequests");
        }
    }
}
