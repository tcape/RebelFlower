using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KendraMakeupArtist.Data.Migrations
{
    public partial class InitialTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AppointmentRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentType = table.Column<int>(nullable: false),
                    RequestStatus = table.Column<int>(nullable: false),
                    RequestDateTime = table.Column<DateTime>(nullable: false),
                    AppointmentDateTime = table.Column<DateTime>(nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 500, nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    Zip = table.Column<string>(nullable: false),
                    ContactPhone = table.Column<string>(nullable: false),
                    AlternatePhone = table.Column<string>(nullable: false),
                    ContactEmail = table.Column<string>(nullable: false),
                    VIP = table.Column<int>(nullable: false),
                    AddOns = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAppointmentRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    AppointmentRequestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAppointmentRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAppointmentRequests_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAppointmentRequests_AppointmentRequests_AppointmentRequestId",
                        column: x => x.AppointmentRequestId,
                        principalTable: "AppointmentRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAppointmentRequests_ApplicationUserId",
                table: "UserAppointmentRequests",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAppointmentRequests_AppointmentRequestId",
                table: "UserAppointmentRequests",
                column: "AppointmentRequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAppointmentRequests");

            migrationBuilder.DropTable(
                name: "AppointmentRequests");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
