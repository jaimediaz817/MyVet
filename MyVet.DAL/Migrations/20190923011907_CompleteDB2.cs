using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVet.DAL.Migrations
{
    public partial class CompleteDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_pets_PetId",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_pets_PetId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_pets_Owners_OwnerId",
                table: "pets");

            migrationBuilder.DropForeignKey(
                name: "FK_pets_petTypes_PetTypeId",
                table: "pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_petTypes",
                table: "petTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pets",
                table: "pets");

            migrationBuilder.RenameTable(
                name: "petTypes",
                newName: "PetTypes");

            migrationBuilder.RenameTable(
                name: "pets",
                newName: "Pets");

            migrationBuilder.RenameIndex(
                name: "IX_pets_PetTypeId",
                table: "Pets",
                newName: "IX_Pets_PetTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_pets_OwnerId",
                table: "Pets",
                newName: "IX_Pets_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetTypes",
                table: "PetTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pets",
                table: "Pets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Pets_PetId",
                table: "Agendas",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Pets_PetId",
                table: "Histories",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Owners_OwnerId",
                table: "Pets",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetTypes_PetTypeId",
                table: "Pets",
                column: "PetTypeId",
                principalTable: "PetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Pets_PetId",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Pets_PetId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Owners_OwnerId",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetTypes_PetTypeId",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetTypes",
                table: "PetTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pets",
                table: "Pets");

            migrationBuilder.RenameTable(
                name: "PetTypes",
                newName: "petTypes");

            migrationBuilder.RenameTable(
                name: "Pets",
                newName: "pets");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_PetTypeId",
                table: "pets",
                newName: "IX_pets_PetTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_OwnerId",
                table: "pets",
                newName: "IX_pets_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_petTypes",
                table: "petTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pets",
                table: "pets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_pets_PetId",
                table: "Agendas",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_pets_PetId",
                table: "Histories",
                column: "PetId",
                principalTable: "pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pets_Owners_OwnerId",
                table: "pets",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pets_petTypes_PetTypeId",
                table: "pets",
                column: "PetTypeId",
                principalTable: "petTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
