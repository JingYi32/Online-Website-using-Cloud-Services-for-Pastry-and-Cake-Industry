using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DDAC_Assignment.Migrations
{
    public partial class updateUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CustomerDOB",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CustomerFullName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerGender",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserRole",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerDOB",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerFullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerGender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "user_contact_no",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "user_dob",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "user_email",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_username",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
