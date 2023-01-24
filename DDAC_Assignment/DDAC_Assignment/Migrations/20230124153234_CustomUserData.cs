using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DDAC_Assignment.Migrations
{
    public partial class CustomUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "user_contact_no",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "user_dob",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "user_email",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_gender",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_password",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_role",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_username",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePlacedOn = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    PaymentMethod = table.Column<string>(nullable: true),
                    PaymentStatus = table.Column<string>(nullable: true),
                    DeliveryStatus = table.Column<string>(nullable: true),
                    DeliveryContact = table.Column<string>(nullable: true),
                    DeliveryAddress = table.Column<string>(nullable: true),
                    EstimatedArrivalDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    ProductQuantity = table.Column<int>(nullable: false),
                    ProductUnitPrice = table.Column<decimal>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    OrderRating = table.Column<int>(nullable: false),
                    OrderComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.OrderProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "user_contact_no",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "user_dob",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "user_email",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "user_gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "user_name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "user_password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "user_role",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "user_username",
                table: "AspNetUsers");
        }
    }
}
