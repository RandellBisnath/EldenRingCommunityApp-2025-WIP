using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldenRingCommunityApp.Migrations
{
    /// <inheritdoc />
    public partial class addManyToManyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildSpell");

            migrationBuilder.DropTable(
                name: "BuildTalisman");

            migrationBuilder.CreateTable(
                name: "BuildSpells",
                columns: table => new
                {
                    BuildSpellsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildId = table.Column<int>(type: "int", nullable: false),
                    SpellId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildSpells", x => x.BuildSpellsId);
                    table.ForeignKey(
                        name: "FK_BuildSpells_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "BuildID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildSpells_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildTalismans",
                columns: table => new
                {
                    BuildTalismansId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildId = table.Column<int>(type: "int", nullable: false),
                    TalismanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildTalismans", x => x.BuildTalismansId);
                    table.ForeignKey(
                        name: "FK_BuildTalismans_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "BuildID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildTalismans_Talismans_TalismanId",
                        column: x => x.TalismanId,
                        principalTable: "Talismans",
                        principalColumn: "TalismanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildSpells_BuildId",
                table: "BuildSpells",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildSpells_SpellId",
                table: "BuildSpells",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildTalismans_BuildId",
                table: "BuildTalismans",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildTalismans_TalismanId",
                table: "BuildTalismans",
                column: "TalismanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildSpells");

            migrationBuilder.DropTable(
                name: "BuildTalismans");

            migrationBuilder.CreateTable(
                name: "BuildSpell",
                columns: table => new
                {
                    BuildsBuildID = table.Column<int>(type: "int", nullable: false),
                    SpellsSpellID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildSpell", x => new { x.BuildsBuildID, x.SpellsSpellID });
                    table.ForeignKey(
                        name: "FK_BuildSpell_Builds_BuildsBuildID",
                        column: x => x.BuildsBuildID,
                        principalTable: "Builds",
                        principalColumn: "BuildID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildSpell_Spells_SpellsSpellID",
                        column: x => x.SpellsSpellID,
                        principalTable: "Spells",
                        principalColumn: "SpellID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildTalisman",
                columns: table => new
                {
                    BuildsBuildID = table.Column<int>(type: "int", nullable: false),
                    TalismansTalismanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildTalisman", x => new { x.BuildsBuildID, x.TalismansTalismanID });
                    table.ForeignKey(
                        name: "FK_BuildTalisman_Builds_BuildsBuildID",
                        column: x => x.BuildsBuildID,
                        principalTable: "Builds",
                        principalColumn: "BuildID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildTalisman_Talismans_TalismansTalismanID",
                        column: x => x.TalismansTalismanID,
                        principalTable: "Talismans",
                        principalColumn: "TalismanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildSpell_SpellsSpellID",
                table: "BuildSpell",
                column: "SpellsSpellID");

            migrationBuilder.CreateIndex(
                name: "IX_BuildTalisman_TalismansTalismanID",
                table: "BuildTalisman",
                column: "TalismansTalismanID");
        }
    }
}
