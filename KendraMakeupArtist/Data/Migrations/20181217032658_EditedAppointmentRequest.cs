using Microsoft.EntityFrameworkCore.Migrations;

namespace KendraMakeupArtist.Data.Migrations
{
    public partial class EditedAppointmentRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentRequests_AspNetUsers_ApplicationUserId",
                table: "AppointmentRequests");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentRequests_ApplicationUserId",
                table: "AppointmentRequests");

            migrationBuilder.DropColumn(
                name: "AddOns",
                table: "AppointmentRequests");

            migrationBuilder.DropColumn(
                name: "AlternatePhone",
                table: "AppointmentRequests");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AppointmentRequests");

            migrationBuilder.DropColumn(
                name: "VIP",
                table: "AppointmentRequests");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "AppointmentRequests");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "AppointmentRequests",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "AppointmentRequests",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPhone",
                table: "AppointmentRequests",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AppointmentRequests",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "AppointmentRequests",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AppointmentRequests");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "AppointmentRequests");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "AppointmentRequests",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AppointmentRequests",
                newName: "State");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPhone",
                table: "AppointmentRequests",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddOns",
                table: "AppointmentRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AlternatePhone",
                table: "AppointmentRequests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AppointmentRequests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VIP",
                table: "AppointmentRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "AppointmentRequests",
                nullable: false,
                defaultValue: "");

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
    }
}
