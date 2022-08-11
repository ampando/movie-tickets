using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTickets.solution.Migrations
{
    public partial class movietickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concessions",
                columns: table => new
                {
                    ConcessionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Snacks = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Booze = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Candy = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concessions", x => x.ConcessionsId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Theaters",
                columns: table => new
                {
                    TheaterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theaters", x => x.TheaterId);
                });

            migrationBuilder.CreateTable(
                name: "ConcessionsTheater",
                columns: table => new
                {
                    ConcessionsTheaterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TheaterId = table.Column<int>(type: "int", nullable: false),
                    ConcessionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcessionsTheater", x => x.ConcessionsTheaterId);
                    table.ForeignKey(
                        name: "FK_ConcessionsTheater_Concessions_ConcessionsId",
                        column: x => x.ConcessionsId,
                        principalTable: "Concessions",
                        principalColumn: "ConcessionsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConcessionsTheater_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "TheaterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieTheater",
                columns: table => new
                {
                    MovieTheaterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TheaterId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTheater", x => x.MovieTheaterId);
                    table.ForeignKey(
                        name: "FK_MovieTheater_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieTheater_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "TheaterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConcessionsTheater_ConcessionsId",
                table: "ConcessionsTheater",
                column: "ConcessionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConcessionsTheater_TheaterId",
                table: "ConcessionsTheater",
                column: "TheaterId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieTheater_MovieId",
                table: "MovieTheater",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieTheater_TheaterId",
                table: "MovieTheater",
                column: "TheaterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConcessionsTheater");

            migrationBuilder.DropTable(
                name: "MovieTheater");

            migrationBuilder.DropTable(
                name: "Concessions");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Theaters");
        }
    }
}
