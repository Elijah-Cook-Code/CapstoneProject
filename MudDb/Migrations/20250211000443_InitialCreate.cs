using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudDb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    A_ChestMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    B_SeatMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    C_WaistMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    D_TrouserMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    E_F_HalfBackMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    G_H_BackNeckToWaistMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    G_I_SyceDepthMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    I_L_SleeveLengthOnePieceMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    E_I_SleeveLengthTwoPieceMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    N_InsideLegMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    P_Q_BodyRiseMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    R_CloseWristMeasurement = table.Column<int>(type: "INTEGER", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
