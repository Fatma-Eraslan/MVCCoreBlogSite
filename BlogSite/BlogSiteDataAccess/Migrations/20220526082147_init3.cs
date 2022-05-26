using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteDataAccess.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EMail", "FirstName", "LastName", "Password" },
                values: new object[] { 1, "admin@mail.com", "Admin", "Admin", "1234" });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "BirthDate", "Explanation", "Gender", "IsActive", "Job", "Photo", "UserID", "UserRole", "Username" },
                values: new object[] { 1, null, "Admin", true, true, "Admin", null, 1, 0, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
