using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourBlog.Migrations
{
    public partial class RelacionamentoNM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Comentario_AspNetUsers_UsuarioId",
                table: "Tbl_Comentario");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Comentario_Tbl_Postagem_PostagemId",
                table: "Tbl_Comentario");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Tbl_Comentario",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Comentario_AspNetUsers_UsuarioId",
                table: "Tbl_Comentario",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Comentario_Tbl_Postagem_PostagemId",
                table: "Tbl_Comentario",
                column: "PostagemId",
                principalTable: "Tbl_Postagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Comentario_AspNetUsers_UsuarioId",
                table: "Tbl_Comentario");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Comentario_Tbl_Postagem_PostagemId",
                table: "Tbl_Comentario");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Tbl_Comentario",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Comentario_AspNetUsers_UsuarioId",
                table: "Tbl_Comentario",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Comentario_Tbl_Postagem_PostagemId",
                table: "Tbl_Comentario",
                column: "PostagemId",
                principalTable: "Tbl_Postagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
