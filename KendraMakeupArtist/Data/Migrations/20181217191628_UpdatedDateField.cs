using Microsoft.EntityFrameworkCore.Migrations;

namespace KendraMakeupArtist.Data.Migrations
{
    public partial class UpdatedDateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentDateTime",
                table: "AppointmentRequests",
                newName: "AppointmentDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "AppointmentRequests",
                newName: "AppointmentDateTime");
        }
    }
}
