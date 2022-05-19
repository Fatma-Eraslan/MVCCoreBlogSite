using Microsoft.EntityFrameworkCore.Migrations;

namespace WebUI.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesTopics_Articles_ArticlesID",
                table: "ArticlesTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesTopics_Topics_TopicsID",
                table: "ArticlesTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicsUsers_Topics_TopicsID",
                table: "TopicsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicsUsers_Users_UsersID",
                table: "TopicsUsers");

            migrationBuilder.RenameColumn(
                name: "UsersID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserDetailID",
                table: "UserDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UsersID",
                table: "TopicsUsers",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "TopicsID",
                table: "TopicsUsers",
                newName: "TopicsId");

            migrationBuilder.RenameIndex(
                name: "IX_TopicsUsers_UsersID",
                table: "TopicsUsers",
                newName: "IX_TopicsUsers_UsersId");

            migrationBuilder.RenameColumn(
                name: "TopicsID",
                table: "Topics",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TopicsID",
                table: "ArticlesTopics",
                newName: "TopicsId");

            migrationBuilder.RenameColumn(
                name: "ArticlesID",
                table: "ArticlesTopics",
                newName: "ArticlesId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticlesTopics_TopicsID",
                table: "ArticlesTopics",
                newName: "IX_ArticlesTopics_TopicsId");

            migrationBuilder.RenameColumn(
                name: "ArticlesID",
                table: "Articles",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesTopics_Articles_ArticlesId",
                table: "ArticlesTopics",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesTopics_Topics_TopicsId",
                table: "ArticlesTopics",
                column: "TopicsId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicsUsers_Topics_TopicsId",
                table: "TopicsUsers",
                column: "TopicsId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicsUsers_Users_UsersId",
                table: "TopicsUsers",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesTopics_Articles_ArticlesId",
                table: "ArticlesTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesTopics_Topics_TopicsId",
                table: "ArticlesTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicsUsers_Topics_TopicsId",
                table: "TopicsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TopicsUsers_Users_UsersId",
                table: "TopicsUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UsersID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserDetails",
                newName: "UserDetailID");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "TopicsUsers",
                newName: "UsersID");

            migrationBuilder.RenameColumn(
                name: "TopicsId",
                table: "TopicsUsers",
                newName: "TopicsID");

            migrationBuilder.RenameIndex(
                name: "IX_TopicsUsers_UsersId",
                table: "TopicsUsers",
                newName: "IX_TopicsUsers_UsersID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Topics",
                newName: "TopicsID");

            migrationBuilder.RenameColumn(
                name: "TopicsId",
                table: "ArticlesTopics",
                newName: "TopicsID");

            migrationBuilder.RenameColumn(
                name: "ArticlesId",
                table: "ArticlesTopics",
                newName: "ArticlesID");

            migrationBuilder.RenameIndex(
                name: "IX_ArticlesTopics_TopicsId",
                table: "ArticlesTopics",
                newName: "IX_ArticlesTopics_TopicsID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Articles",
                newName: "ArticlesID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesTopics_Articles_ArticlesID",
                table: "ArticlesTopics",
                column: "ArticlesID",
                principalTable: "Articles",
                principalColumn: "ArticlesID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesTopics_Topics_TopicsID",
                table: "ArticlesTopics",
                column: "TopicsID",
                principalTable: "Topics",
                principalColumn: "TopicsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicsUsers_Topics_TopicsID",
                table: "TopicsUsers",
                column: "TopicsID",
                principalTable: "Topics",
                principalColumn: "TopicsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TopicsUsers_Users_UsersID",
                table: "TopicsUsers",
                column: "UsersID",
                principalTable: "Users",
                principalColumn: "UsersID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
