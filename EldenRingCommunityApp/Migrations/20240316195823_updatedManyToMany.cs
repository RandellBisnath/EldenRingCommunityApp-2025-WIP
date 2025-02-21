using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldenRingCommunityApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildWeapon");

            migrationBuilder.CreateTable(
                name: "BuildWeapons",
                columns: table => new
                {
                    BuildWeaponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildId = table.Column<int>(type: "int", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildWeapons", x => x.BuildWeaponId);
                    table.ForeignKey(
                        name: "FK_BuildWeapons_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "BuildID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildWeapons_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "WeaponID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildWeapons_BuildId",
                table: "BuildWeapons",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildWeapons_WeaponId",
                table: "BuildWeapons",
                column: "WeaponId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildWeapons");

            migrationBuilder.CreateTable(
                name: "BuildWeapon",
                columns: table => new
                {
                    BuildsBuildID = table.Column<int>(type: "int", nullable: false),
                    WeaponsWeaponID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildWeapon", x => new { x.BuildsBuildID, x.WeaponsWeaponID });
                    table.ForeignKey(
                        name: "FK_BuildWeapon_Builds_BuildsBuildID",
                        column: x => x.BuildsBuildID,
                        principalTable: "Builds",
                        principalColumn: "BuildID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildWeapon_Weapons_WeaponsWeaponID",
                        column: x => x.WeaponsWeaponID,
                        principalTable: "Weapons",
                        principalColumn: "WeaponID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildWeapon_WeaponsWeaponID",
                table: "BuildWeapon",
                column: "WeaponsWeaponID");
        }
    }
}
