using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeorgianGym.Migrations
{
    public partial class removedSchedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    endTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    exercise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedule_UserId",
                        column: x => x.UsersId,
                        principalTable: "Userss",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_UsersId",
                table: "Schedules",
                column: "UsersId");
        }
    }
}
