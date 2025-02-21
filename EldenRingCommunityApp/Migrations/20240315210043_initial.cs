using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldenRingCommunityApp.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AshOfWar",
                columns: table => new
                {
                    AshOfWarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Affinity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AshOfWar", x => x.AshOfWarID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChestArmors",
                columns: table => new
                {
                    ChestArmorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalResist = table.Column<double>(type: "float", nullable: false),
                    VsStrike = table.Column<double>(type: "float", nullable: false),
                    VsSlash = table.Column<double>(type: "float", nullable: false),
                    VsPierce = table.Column<double>(type: "float", nullable: false),
                    MagicResist = table.Column<double>(type: "float", nullable: false),
                    FireResist = table.Column<double>(type: "float", nullable: false),
                    LightningResist = table.Column<double>(type: "float", nullable: false),
                    HolyResist = table.Column<double>(type: "float", nullable: false),
                    Immunity = table.Column<int>(type: "int", nullable: false),
                    Robustness = table.Column<int>(type: "int", nullable: false),
                    Focus = table.Column<int>(type: "int", nullable: false),
                    Vitality = table.Column<int>(type: "int", nullable: false),
                    Poise = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChestArmors", x => x.ChestArmorID);
                });

            migrationBuilder.CreateTable(
                name: "Gauntlets",
                columns: table => new
                {
                    GauntletsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalResist = table.Column<double>(type: "float", nullable: false),
                    VsStrike = table.Column<double>(type: "float", nullable: false),
                    VsSlash = table.Column<double>(type: "float", nullable: false),
                    VsPierce = table.Column<double>(type: "float", nullable: false),
                    MagicResist = table.Column<double>(type: "float", nullable: false),
                    FireResist = table.Column<double>(type: "float", nullable: false),
                    LightningResist = table.Column<double>(type: "float", nullable: false),
                    HolyResist = table.Column<double>(type: "float", nullable: false),
                    Immunity = table.Column<int>(type: "int", nullable: false),
                    Robustness = table.Column<int>(type: "int", nullable: false),
                    Focus = table.Column<int>(type: "int", nullable: false),
                    Vitality = table.Column<int>(type: "int", nullable: false),
                    Poise = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gauntlets", x => x.GauntletsID);
                });

            migrationBuilder.CreateTable(
                name: "Helmets",
                columns: table => new
                {
                    HelmetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalResist = table.Column<double>(type: "float", nullable: false),
                    VsStrike = table.Column<double>(type: "float", nullable: false),
                    VsSlash = table.Column<double>(type: "float", nullable: false),
                    VsPierce = table.Column<double>(type: "float", nullable: false),
                    MagicResist = table.Column<double>(type: "float", nullable: false),
                    FireResist = table.Column<double>(type: "float", nullable: false),
                    LightningResist = table.Column<double>(type: "float", nullable: false),
                    HolyResist = table.Column<double>(type: "float", nullable: false),
                    Immunity = table.Column<int>(type: "int", nullable: false),
                    Robustness = table.Column<int>(type: "int", nullable: false),
                    Focus = table.Column<int>(type: "int", nullable: false),
                    Vitality = table.Column<int>(type: "int", nullable: false),
                    Poise = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helmets", x => x.HelmetID);
                });

            migrationBuilder.CreateTable(
                name: "LegArmors",
                columns: table => new
                {
                    LegArmorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalResist = table.Column<double>(type: "float", nullable: false),
                    VsStrike = table.Column<double>(type: "float", nullable: false),
                    VsSlash = table.Column<double>(type: "float", nullable: false),
                    VsPierce = table.Column<double>(type: "float", nullable: false),
                    MagicResist = table.Column<double>(type: "float", nullable: false),
                    FireResist = table.Column<double>(type: "float", nullable: false),
                    LightningResist = table.Column<double>(type: "float", nullable: false),
                    HolyResist = table.Column<double>(type: "float", nullable: false),
                    Immunity = table.Column<int>(type: "int", nullable: false),
                    Robustness = table.Column<int>(type: "int", nullable: false),
                    Focus = table.Column<int>(type: "int", nullable: false),
                    Vitality = table.Column<int>(type: "int", nullable: false),
                    Poise = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegArmors", x => x.LegArmorID);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    SpellID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FPCost = table.Column<int>(type: "int", nullable: false),
                    StaminaCost = table.Column<int>(type: "int", nullable: false),
                    SlotsUsed = table.Column<int>(type: "int", nullable: false),
                    IntelligenceRequirement = table.Column<int>(type: "int", nullable: false),
                    FaithRequirement = table.Column<int>(type: "int", nullable: false),
                    ArcaneRequirement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.SpellID);
                });

            migrationBuilder.CreateTable(
                name: "StartingClasses",
                columns: table => new
                {
                    StartingClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vigor = table.Column<int>(type: "int", nullable: false),
                    Mind = table.Column<int>(type: "int", nullable: false),
                    Endurance = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Faith = table.Column<int>(type: "int", nullable: false),
                    Arcane = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartingClasses", x => x.StartingClassID);
                });

            migrationBuilder.CreateTable(
                name: "Talismans",
                columns: table => new
                {
                    TalismanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talismans", x => x.TalismanID);
                });

            migrationBuilder.CreateTable(
                name: "WeaponType",
                columns: table => new
                {
                    WeaponTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponType", x => x.WeaponTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tutorials",
                columns: table => new
                {
                    TutorialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutorials", x => x.TutorialID);
                    table.ForeignKey(
                        name: "FK_Tutorials_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    BuildID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vigor = table.Column<int>(type: "int", nullable: false),
                    Mind = table.Column<int>(type: "int", nullable: false),
                    Endurance = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Faith = table.Column<int>(type: "int", nullable: false),
                    Arcane = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartingClassID = table.Column<int>(type: "int", nullable: false),
                    HelmetID = table.Column<int>(type: "int", nullable: false),
                    ChestArmorID = table.Column<int>(type: "int", nullable: false),
                    GauntletsID = table.Column<int>(type: "int", nullable: false),
                    LegArmorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.BuildID);
                    table.ForeignKey(
                        name: "FK_Builds_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_ChestArmors_ChestArmorID",
                        column: x => x.ChestArmorID,
                        principalTable: "ChestArmors",
                        principalColumn: "ChestArmorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Gauntlets_GauntletsID",
                        column: x => x.GauntletsID,
                        principalTable: "Gauntlets",
                        principalColumn: "GauntletsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Helmets_HelmetID",
                        column: x => x.HelmetID,
                        principalTable: "Helmets",
                        principalColumn: "HelmetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_LegArmors_LegArmorID",
                        column: x => x.LegArmorID,
                        principalTable: "LegArmors",
                        principalColumn: "LegArmorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_StartingClasses_StartingClassID",
                        column: x => x.StartingClassID,
                        principalTable: "StartingClasses",
                        principalColumn: "StartingClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    WeaponID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthRequirement = table.Column<int>(type: "int", nullable: false),
                    DexterityRequirement = table.Column<int>(type: "int", nullable: false),
                    IntelligenceRequirement = table.Column<int>(type: "int", nullable: false),
                    FaithRequirement = table.Column<int>(type: "int", nullable: false),
                    ArcaneRequirement = table.Column<int>(type: "int", nullable: false),
                    PhysicalDamage = table.Column<int>(type: "int", nullable: false),
                    MagicDamage = table.Column<int>(type: "int", nullable: false),
                    FireDamage = table.Column<int>(type: "int", nullable: false),
                    LightningDamage = table.Column<int>(type: "int", nullable: false),
                    HolyDamage = table.Column<int>(type: "int", nullable: false),
                    CritModifier = table.Column<int>(type: "int", nullable: false),
                    PhysicalGuard = table.Column<int>(type: "int", nullable: false),
                    MagicGuard = table.Column<int>(type: "int", nullable: false),
                    FireGuard = table.Column<int>(type: "int", nullable: false),
                    LightningGuard = table.Column<int>(type: "int", nullable: false),
                    HolyGuard = table.Column<int>(type: "int", nullable: false),
                    Boost = table.Column<int>(type: "int", nullable: false),
                    StrengthScaling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DexterityScaling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntelligenceScaling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaithScaling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArcaneScaling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    PassiveEffect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paired = table.Column<bool>(type: "bit", nullable: false),
                    WeaponTypeID = table.Column<int>(type: "int", nullable: false),
                    AshOfWarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.WeaponID);
                    table.ForeignKey(
                        name: "FK_Weapons_AshOfWar_AshOfWarID",
                        column: x => x.AshOfWarID,
                        principalTable: "AshOfWar",
                        principalColumn: "AshOfWarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weapons_WeaponType_WeaponTypeID",
                        column: x => x.WeaponTypeID,
                        principalTable: "WeaponType",
                        principalColumn: "WeaponTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_ChestArmorID",
                table: "Builds",
                column: "ChestArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_GauntletsID",
                table: "Builds",
                column: "GauntletsID");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_HelmetID",
                table: "Builds",
                column: "HelmetID");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_LegArmorID",
                table: "Builds",
                column: "LegArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_StartingClassID",
                table: "Builds",
                column: "StartingClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_UserID",
                table: "Builds",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BuildSpell_SpellsSpellID",
                table: "BuildSpell",
                column: "SpellsSpellID");

            migrationBuilder.CreateIndex(
                name: "IX_BuildTalisman_TalismansTalismanID",
                table: "BuildTalisman",
                column: "TalismansTalismanID");

            migrationBuilder.CreateIndex(
                name: "IX_BuildWeapon_WeaponsWeaponID",
                table: "BuildWeapon",
                column: "WeaponsWeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserID",
                table: "Messages",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tutorials_UserID",
                table: "Tutorials",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_AshOfWarID",
                table: "Weapons",
                column: "AshOfWarID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WeaponTypeID",
                table: "Weapons",
                column: "WeaponTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BuildSpell");

            migrationBuilder.DropTable(
                name: "BuildTalisman");

            migrationBuilder.DropTable(
                name: "BuildWeapon");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Tutorials");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Talismans");

            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ChestArmors");

            migrationBuilder.DropTable(
                name: "Gauntlets");

            migrationBuilder.DropTable(
                name: "Helmets");

            migrationBuilder.DropTable(
                name: "LegArmors");

            migrationBuilder.DropTable(
                name: "StartingClasses");

            migrationBuilder.DropTable(
                name: "AshOfWar");

            migrationBuilder.DropTable(
                name: "WeaponType");
        }
    }
}
