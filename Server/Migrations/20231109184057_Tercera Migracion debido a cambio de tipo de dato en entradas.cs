using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Julio_AP1_P2.Server.Migrations
{
    /// <inheritdoc />
    public partial class TerceraMigraciondebidoacambiodetipodedatoenentradas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CantidadProducida",
                table: "Entradas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CantidadProducida",
                table: "Entradas",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
