using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Office_Seat_Booking_DLL.Migrations
{
    /// <inheritdoc />
    public partial class appppp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_seat_Seat_No1",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "FK_seat_floor_FloorID",
                table: "seat");

            migrationBuilder.DropIndex(
                name: "IX_seat_FloorID",
                table: "seat");

            migrationBuilder.DropIndex(
                name: "IX_booking_Seat_No1",
                table: "booking");

            migrationBuilder.DropColumn(
                name: "Seat_No1",
                table: "booking");

            migrationBuilder.RenameColumn(
                name: "FloorID",
                table: "seat",
                newName: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_seat_BookingId",
                table: "seat",
                column: "BookingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_seat_booking_BookingId",
                table: "seat",
                column: "BookingId",
                principalTable: "booking",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_seat_booking_BookingId",
                table: "seat");

            migrationBuilder.DropIndex(
                name: "IX_seat_BookingId",
                table: "seat");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "seat",
                newName: "FloorID");

            migrationBuilder.AddColumn<int>(
                name: "Seat_No1",
                table: "booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_seat_FloorID",
                table: "seat",
                column: "FloorID");

            migrationBuilder.CreateIndex(
                name: "IX_booking_Seat_No1",
                table: "booking",
                column: "Seat_No1");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_seat_Seat_No1",
                table: "booking",
                column: "Seat_No1",
                principalTable: "seat",
                principalColumn: "Seat_No",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_seat_floor_FloorID",
                table: "seat",
                column: "FloorID",
                principalTable: "floor",
                principalColumn: "FloorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
