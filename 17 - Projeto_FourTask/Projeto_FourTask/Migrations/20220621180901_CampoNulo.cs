﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_FourTask.Migrations
{
    public partial class CampoNulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tbl_Equipe_EquipeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Tarefa_AspNetUsers_UsuarioId",
                table: "Tbl_Tarefa");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Tarefa_UsuarioId",
                table: "Tbl_Tarefa");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Tbl_Tarefa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId1",
                table: "Tbl_Tarefa",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipeId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Tarefa_UsuarioId1",
                table: "Tbl_Tarefa",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tbl_Equipe_EquipeId",
                table: "AspNetUsers",
                column: "EquipeId",
                principalTable: "Tbl_Equipe",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Tarefa_AspNetUsers_UsuarioId1",
                table: "Tbl_Tarefa",
                column: "UsuarioId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tbl_Equipe_EquipeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Tarefa_AspNetUsers_UsuarioId1",
                table: "Tbl_Tarefa");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Tarefa_UsuarioId1",
                table: "Tbl_Tarefa");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Tbl_Tarefa");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Tbl_Tarefa",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EquipeId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Tarefa_UsuarioId",
                table: "Tbl_Tarefa",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tbl_Equipe_EquipeId",
                table: "AspNetUsers",
                column: "EquipeId",
                principalTable: "Tbl_Equipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Tarefa_AspNetUsers_UsuarioId",
                table: "Tbl_Tarefa",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
