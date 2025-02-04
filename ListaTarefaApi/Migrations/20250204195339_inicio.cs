using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaTarefaApi.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoTarefa",
                columns: table => new
                {
                    TipoTarefaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarefa", x => x.TipoTarefaId);
                });

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    tarefaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Concluida = table.Column<bool>(type: "bit", nullable: false),
                    TipoTarefaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.tarefaId);
                    table.ForeignKey(
                        name: "FK_Tarefas_TipoTarefa_TipoTarefaId",
                        column: x => x.TipoTarefaId,
                        principalTable: "TipoTarefa",
                        principalColumn: "TipoTarefaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_TipoTarefaId",
                table: "Tarefas",
                column: "TipoTarefaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");

            migrationBuilder.DropTable(
                name: "TipoTarefa");
        }
    }
}
