using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitializeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participation",
                columns: table => new
                {
                    ParticipationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LegacyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participation", x => x.ParticipationId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_M1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipationId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CHANGEMO = table.Column<int>(type: "int", nullable: true),
                    CHANGEDY = table.Column<int>(type: "int", nullable: true),
                    CHANGEYR = table.Column<int>(type: "int", nullable: true),
                    PROTOCOL = table.Column<int>(type: "int", nullable: true),
                    ACONSENT = table.Column<int>(type: "int", nullable: true),
                    RECOGIM = table.Column<int>(type: "int", nullable: true),
                    REPHYILL = table.Column<int>(type: "int", nullable: true),
                    REREFUSE = table.Column<int>(type: "int", nullable: true),
                    RENAVAIL = table.Column<int>(type: "int", nullable: true),
                    RENURSE = table.Column<int>(type: "int", nullable: true),
                    NURSEMO = table.Column<int>(type: "int", nullable: true),
                    NURSEDY = table.Column<int>(type: "int", nullable: true),
                    NURSEYR = table.Column<int>(type: "int", nullable: true),
                    REJOIN = table.Column<int>(type: "int", nullable: true),
                    FTLDDISC = table.Column<int>(type: "int", nullable: true),
                    FTLDREAS = table.Column<int>(type: "int", nullable: true),
                    FTLDREAX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DECEASED = table.Column<int>(type: "int", nullable: true),
                    DISCONT = table.Column<int>(type: "int", nullable: true),
                    DEATHMO = table.Column<int>(type: "int", nullable: true),
                    DEATHDY = table.Column<int>(type: "int", nullable: true),
                    DEATHYR = table.Column<int>(type: "int", nullable: true),
                    AUTOPSY = table.Column<int>(type: "int", nullable: true),
                    DISCMO = table.Column<int>(type: "int", nullable: true),
                    DISCDAY = table.Column<int>(type: "int", nullable: true),
                    DISCYR = table.Column<int>(type: "int", nullable: true),
                    DROPREAS = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_M1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_M1s_Participation_ParticipationId",
                        column: x => x.ParticipationId,
                        principalTable: "Participation",
                        principalColumn: "ParticipationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Visits",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipationId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Version = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_tbl_Visits_Participation_ParticipationId",
                        column: x => x.ParticipationId,
                        principalTable: "Participation",
                        principalColumn: "ParticipationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REASON = table.Column<int>(type: "int", nullable: true),
                    REFERSC = table.Column<int>(type: "int", nullable: true),
                    LEARNED = table.Column<int>(type: "int", nullable: true),
                    PRESTAT = table.Column<int>(type: "int", nullable: true),
                    PRESPART = table.Column<int>(type: "int", nullable: true),
                    SOURCENW = table.Column<int>(type: "int", nullable: true),
                    BIRTHMO = table.Column<int>(type: "int", nullable: true),
                    BIRTHYR = table.Column<int>(type: "int", nullable: true),
                    SEX = table.Column<int>(type: "int", nullable: true),
                    HISPANIC = table.Column<int>(type: "int", nullable: true),
                    HISPOR = table.Column<int>(type: "int", nullable: true),
                    HISPORX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACE = table.Column<int>(type: "int", nullable: true),
                    RACEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACESEC = table.Column<int>(type: "int", nullable: true),
                    RACESECX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACETER = table.Column<int>(type: "int", nullable: true),
                    RACETERX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PRIMLANG = table.Column<int>(type: "int", nullable: true),
                    PRIMLANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EDUC = table.Column<int>(type: "int", nullable: true),
                    MARISTAT = table.Column<int>(type: "int", nullable: true),
                    LIVSITUA = table.Column<int>(type: "int", nullable: true),
                    INDEPEND = table.Column<int>(type: "int", nullable: true),
                    RESIDENC = table.Column<int>(type: "int", nullable: true),
                    ZIP = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    HANDED = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A2s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INBIRMO = table.Column<int>(type: "int", nullable: true),
                    INBIRYR = table.Column<int>(type: "int", nullable: true),
                    INSEX = table.Column<int>(type: "int", nullable: true),
                    INHISP = table.Column<int>(type: "int", nullable: true),
                    INHISPOR = table.Column<int>(type: "int", nullable: true),
                    INHISPOX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    INRACE = table.Column<int>(type: "int", nullable: true),
                    INRACEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    INRASEC = table.Column<int>(type: "int", nullable: true),
                    INRASECX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    INRATER = table.Column<int>(type: "int", nullable: true),
                    INRATERX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    INEDUC = table.Column<int>(type: "int", nullable: true),
                    INRELTO = table.Column<int>(type: "int", nullable: true),
                    INKNOWN = table.Column<int>(type: "int", nullable: true),
                    INLIVWTH = table.Column<int>(type: "int", nullable: true),
                    INVISITS = table.Column<int>(type: "int", nullable: true),
                    INCALLS = table.Column<int>(type: "int", nullable: true),
                    INRELY = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A2s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A2s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A3s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AFFFAMM = table.Column<int>(type: "int", nullable: true),
                    NWINFMUT = table.Column<int>(type: "int", nullable: true),
                    FADMUT = table.Column<int>(type: "int", nullable: true),
                    FADMUTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FADMUSO = table.Column<int>(type: "int", nullable: true),
                    FADMUSOX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FFTDMUT = table.Column<int>(type: "int", nullable: true),
                    FFTDMUTX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FFTDMUSO = table.Column<int>(type: "int", nullable: true),
                    FFTDMUSX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FOTHMUT = table.Column<int>(type: "int", nullable: true),
                    FOTHMUTX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FOTHMUSO = table.Column<int>(type: "int", nullable: true),
                    FOTHMUSX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOMMOB = table.Column<int>(type: "int", nullable: true),
                    MOMYOB = table.Column<int>(type: "int", nullable: true),
                    MOMDAGE = table.Column<int>(type: "int", nullable: true),
                    MOMNEUR = table.Column<int>(type: "int", nullable: true),
                    MOMPRDX = table.Column<int>(type: "int", nullable: true),
                    MOMMOE = table.Column<int>(type: "int", nullable: true),
                    MOMAGEO = table.Column<int>(type: "int", nullable: true),
                    DADMOB = table.Column<int>(type: "int", nullable: true),
                    DADYOB = table.Column<int>(type: "int", nullable: true),
                    DADDAGE = table.Column<int>(type: "int", nullable: true),
                    DADNEUR = table.Column<int>(type: "int", nullable: true),
                    DADPRDX = table.Column<int>(type: "int", nullable: true),
                    DADMOE = table.Column<int>(type: "int", nullable: true),
                    DADAGEO = table.Column<int>(type: "int", nullable: true),
                    SIBS = table.Column<int>(type: "int", nullable: true),
                    SIB1_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB1_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB1_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB1_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB1_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB1_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB1_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB2_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB2_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB2_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB2_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB2_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB2_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB2_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB3_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB3_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB3_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB3_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB3_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB3_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB3_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB4_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB4_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB4_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB4_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB4_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB4_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB4_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB5_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB5_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB5_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB5_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB5_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB5_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB5_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB6_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB6_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB6_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB6_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB6_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB6_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB6_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB7_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB7_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB7_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB7_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB7_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB7_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB7_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB8_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB8_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB8_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB8_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB8_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB8_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB8_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB9_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB9_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB9_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB9_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB9_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB9_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB9_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB10_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB10_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB10_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB10_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB10_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB10_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB10_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB11_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB11_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB11_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB11_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB11_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB11_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB11_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB12_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB12_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB12_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB12_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB12_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB12_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB12_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB13_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB13_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB13_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB13_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB13_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB13_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB13_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB14_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB14_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB14_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB14_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB14_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB14_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB14_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB15_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB15_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB15_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB15_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB15_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB15_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB15_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB16_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB16_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB16_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB16_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB16_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB16_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB16_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB17_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB17_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB17_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB17_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB17_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB17_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB17_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB18_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB18_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB18_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB18_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB18_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB18_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB18_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB19_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB19_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB19_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB19_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB19_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB19_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB19_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB20_MOB = table.Column<int>(type: "int", nullable: true),
                    SIB20_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB20_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB20_NEU = table.Column<int>(type: "int", nullable: true),
                    SIB20_PDX = table.Column<int>(type: "int", nullable: true),
                    SIB20_MOE = table.Column<int>(type: "int", nullable: true),
                    SIB20_AGO = table.Column<int>(type: "int", nullable: true),
                    KIDS = table.Column<int>(type: "int", nullable: true),
                    KID1_MOB = table.Column<int>(type: "int", nullable: true),
                    KID1_YOB = table.Column<int>(type: "int", nullable: true),
                    KID1_AGD = table.Column<int>(type: "int", nullable: true),
                    KID1_NEU = table.Column<int>(type: "int", nullable: true),
                    KID1_PDX = table.Column<int>(type: "int", nullable: true),
                    KID1_MOE = table.Column<int>(type: "int", nullable: true),
                    KID1_AGO = table.Column<int>(type: "int", nullable: true),
                    KID2_MOB = table.Column<int>(type: "int", nullable: true),
                    KID2_YOB = table.Column<int>(type: "int", nullable: true),
                    KID2_AGD = table.Column<int>(type: "int", nullable: true),
                    KID2_NEU = table.Column<int>(type: "int", nullable: true),
                    KID2_PDX = table.Column<int>(type: "int", nullable: true),
                    KID2_MOE = table.Column<int>(type: "int", nullable: true),
                    KID2_AGO = table.Column<int>(type: "int", nullable: true),
                    KID3_MOB = table.Column<int>(type: "int", nullable: true),
                    KID3_YOB = table.Column<int>(type: "int", nullable: true),
                    KID3_AGD = table.Column<int>(type: "int", nullable: true),
                    KID3_NEU = table.Column<int>(type: "int", nullable: true),
                    KID3_PDX = table.Column<int>(type: "int", nullable: true),
                    KID3_MOE = table.Column<int>(type: "int", nullable: true),
                    KID3_AGO = table.Column<int>(type: "int", nullable: true),
                    KID4_MOB = table.Column<int>(type: "int", nullable: true),
                    KID4_YOB = table.Column<int>(type: "int", nullable: true),
                    KID4_AGD = table.Column<int>(type: "int", nullable: true),
                    KID4_NEU = table.Column<int>(type: "int", nullable: true),
                    KID4_PDX = table.Column<int>(type: "int", nullable: true),
                    KID4_MOE = table.Column<int>(type: "int", nullable: true),
                    KID4_AGO = table.Column<int>(type: "int", nullable: true),
                    KID5_MOB = table.Column<int>(type: "int", nullable: true),
                    KID5_YOB = table.Column<int>(type: "int", nullable: true),
                    KID5_AGD = table.Column<int>(type: "int", nullable: true),
                    KID5_NEU = table.Column<int>(type: "int", nullable: true),
                    KID5_PDX = table.Column<int>(type: "int", nullable: true),
                    KID5_MOE = table.Column<int>(type: "int", nullable: true),
                    KID5_AGO = table.Column<int>(type: "int", nullable: true),
                    KID6_MOB = table.Column<int>(type: "int", nullable: true),
                    KID6_YOB = table.Column<int>(type: "int", nullable: true),
                    KID6_AGD = table.Column<int>(type: "int", nullable: true),
                    KID6_NEU = table.Column<int>(type: "int", nullable: true),
                    KID6_PDX = table.Column<int>(type: "int", nullable: true),
                    KID6_MOE = table.Column<int>(type: "int", nullable: true),
                    KID6_AGO = table.Column<int>(type: "int", nullable: true),
                    KID7_MOB = table.Column<int>(type: "int", nullable: true),
                    KID7_YOB = table.Column<int>(type: "int", nullable: true),
                    KID7_AGD = table.Column<int>(type: "int", nullable: true),
                    KID7_NEU = table.Column<int>(type: "int", nullable: true),
                    KID7_PDX = table.Column<int>(type: "int", nullable: true),
                    KID7_MOE = table.Column<int>(type: "int", nullable: true),
                    KID7_AGO = table.Column<int>(type: "int", nullable: true),
                    KID8_MOB = table.Column<int>(type: "int", nullable: true),
                    KID8_YOB = table.Column<int>(type: "int", nullable: true),
                    KID8_AGD = table.Column<int>(type: "int", nullable: true),
                    KID8_NEU = table.Column<int>(type: "int", nullable: true),
                    KID8_PDX = table.Column<int>(type: "int", nullable: true),
                    KID8_MOE = table.Column<int>(type: "int", nullable: true),
                    KID8_AGO = table.Column<int>(type: "int", nullable: true),
                    KID9_MOB = table.Column<int>(type: "int", nullable: true),
                    KID9_YOB = table.Column<int>(type: "int", nullable: true),
                    KID9_AGD = table.Column<int>(type: "int", nullable: true),
                    KID9_NEU = table.Column<int>(type: "int", nullable: true),
                    KID9_PDX = table.Column<int>(type: "int", nullable: true),
                    KID9_MOE = table.Column<int>(type: "int", nullable: true),
                    KID9_AGO = table.Column<int>(type: "int", nullable: true),
                    KID10_MOB = table.Column<int>(type: "int", nullable: true),
                    KID10_YOB = table.Column<int>(type: "int", nullable: true),
                    KID10_AGD = table.Column<int>(type: "int", nullable: true),
                    KID10_NEU = table.Column<int>(type: "int", nullable: true),
                    KID10_PDX = table.Column<int>(type: "int", nullable: true),
                    KID10_MOE = table.Column<int>(type: "int", nullable: true),
                    KID10_AGO = table.Column<int>(type: "int", nullable: true),
                    KID11_MOB = table.Column<int>(type: "int", nullable: true),
                    KID11_YOB = table.Column<int>(type: "int", nullable: true),
                    KID11_AGD = table.Column<int>(type: "int", nullable: true),
                    KID11_NEU = table.Column<int>(type: "int", nullable: true),
                    KID11_PDX = table.Column<int>(type: "int", nullable: true),
                    KID11_MOE = table.Column<int>(type: "int", nullable: true),
                    KID11_AGO = table.Column<int>(type: "int", nullable: true),
                    KID12_MOB = table.Column<int>(type: "int", nullable: true),
                    KID12_YOB = table.Column<int>(type: "int", nullable: true),
                    KID12_AGD = table.Column<int>(type: "int", nullable: true),
                    KID12_NEU = table.Column<int>(type: "int", nullable: true),
                    KID12_PDX = table.Column<int>(type: "int", nullable: true),
                    KID12_MOE = table.Column<int>(type: "int", nullable: true),
                    KID12_AGO = table.Column<int>(type: "int", nullable: true),
                    KID13_MOB = table.Column<int>(type: "int", nullable: true),
                    KID13_YOB = table.Column<int>(type: "int", nullable: true),
                    KID13_AGD = table.Column<int>(type: "int", nullable: true),
                    KID13_NEU = table.Column<int>(type: "int", nullable: true),
                    KID13_PDX = table.Column<int>(type: "int", nullable: true),
                    KID13_MOE = table.Column<int>(type: "int", nullable: true),
                    KID13_AGO = table.Column<int>(type: "int", nullable: true),
                    KID14_MOB = table.Column<int>(type: "int", nullable: true),
                    KID14_YOB = table.Column<int>(type: "int", nullable: true),
                    KID14_AGD = table.Column<int>(type: "int", nullable: true),
                    KID14_NEU = table.Column<int>(type: "int", nullable: true),
                    KID14_PDX = table.Column<int>(type: "int", nullable: true),
                    KID14_MOE = table.Column<int>(type: "int", nullable: true),
                    KID14_AGO = table.Column<int>(type: "int", nullable: true),
                    KID15_MOB = table.Column<int>(type: "int", nullable: true),
                    KID15_YOB = table.Column<int>(type: "int", nullable: true),
                    KID15_AGD = table.Column<int>(type: "int", nullable: true),
                    KID15_NEU = table.Column<int>(type: "int", nullable: true),
                    KID15_PDX = table.Column<int>(type: "int", nullable: true),
                    KID15_MOE = table.Column<int>(type: "int", nullable: true),
                    KID15_AGO = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A3s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A3s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A4Ds",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DRUGID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A4Ds", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A4Ds_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A4Gs",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ANYMEDS = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A4Gs", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A4Gs_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A5s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TOBAC30 = table.Column<int>(type: "int", nullable: true),
                    TOBAC100 = table.Column<int>(type: "int", nullable: true),
                    SMOKYRS = table.Column<int>(type: "int", nullable: true),
                    PACKSPER = table.Column<int>(type: "int", nullable: true),
                    QUITSMOK = table.Column<int>(type: "int", nullable: true),
                    ALCOCCAS = table.Column<int>(type: "int", nullable: true),
                    ALCFREQ = table.Column<int>(type: "int", nullable: true),
                    CVHATT = table.Column<int>(type: "int", nullable: true),
                    HATTMULT = table.Column<int>(type: "int", nullable: true),
                    HATTYEAR = table.Column<int>(type: "int", nullable: true),
                    CVAFIB = table.Column<int>(type: "int", nullable: true),
                    CVANGIO = table.Column<int>(type: "int", nullable: true),
                    CVBYPASS = table.Column<int>(type: "int", nullable: true),
                    CVPACDEF = table.Column<int>(type: "int", nullable: true),
                    CVCHF = table.Column<int>(type: "int", nullable: true),
                    CVANGINA = table.Column<int>(type: "int", nullable: true),
                    CVHVALVE = table.Column<int>(type: "int", nullable: true),
                    CVOTHR = table.Column<int>(type: "int", nullable: true),
                    CVOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CBSTROKE = table.Column<int>(type: "int", nullable: true),
                    STROKMUL = table.Column<int>(type: "int", nullable: true),
                    STROKYR = table.Column<int>(type: "int", nullable: true),
                    CBTIA = table.Column<int>(type: "int", nullable: true),
                    TIAMULT = table.Column<int>(type: "int", nullable: true),
                    TIAYEAR = table.Column<int>(type: "int", nullable: true),
                    PD = table.Column<int>(type: "int", nullable: true),
                    PDYR = table.Column<int>(type: "int", nullable: true),
                    PDOTHR = table.Column<int>(type: "int", nullable: true),
                    PDOTHRYR = table.Column<int>(type: "int", nullable: true),
                    SEIZURES = table.Column<int>(type: "int", nullable: true),
                    TBI = table.Column<int>(type: "int", nullable: true),
                    TBIBRIEF = table.Column<int>(type: "int", nullable: true),
                    TBIEXTEN = table.Column<int>(type: "int", nullable: true),
                    TBIWOLOS = table.Column<int>(type: "int", nullable: true),
                    TBIYEAR = table.Column<int>(type: "int", nullable: true),
                    DIABETES = table.Column<int>(type: "int", nullable: true),
                    DIABTYPE = table.Column<int>(type: "int", nullable: true),
                    HYPERTEN = table.Column<int>(type: "int", nullable: true),
                    HYPERCHO = table.Column<int>(type: "int", nullable: true),
                    B12DEF = table.Column<int>(type: "int", nullable: true),
                    THYROID = table.Column<int>(type: "int", nullable: true),
                    ARTHRIT = table.Column<int>(type: "int", nullable: true),
                    ARTHTYPE = table.Column<int>(type: "int", nullable: true),
                    ARTHTYPX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ARTHUPEX = table.Column<int>(type: "int", nullable: true),
                    ARTHLOEX = table.Column<int>(type: "int", nullable: true),
                    ARTHSPIN = table.Column<int>(type: "int", nullable: true),
                    ARTHUNK = table.Column<int>(type: "int", nullable: true),
                    INCONTU = table.Column<int>(type: "int", nullable: true),
                    INCONTF = table.Column<int>(type: "int", nullable: true),
                    APNEA = table.Column<int>(type: "int", nullable: true),
                    RBD = table.Column<int>(type: "int", nullable: true),
                    INSOMN = table.Column<int>(type: "int", nullable: true),
                    OTHSLEEP = table.Column<int>(type: "int", nullable: true),
                    OTHSLEEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ALCOHOL = table.Column<int>(type: "int", nullable: true),
                    ABUSOTHR = table.Column<int>(type: "int", nullable: true),
                    ABUSX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PTSD = table.Column<int>(type: "int", nullable: true),
                    BIPOLAR = table.Column<int>(type: "int", nullable: true),
                    SCHIZ = table.Column<int>(type: "int", nullable: true),
                    DEP2YRS = table.Column<int>(type: "int", nullable: true),
                    DEPOTHR = table.Column<int>(type: "int", nullable: true),
                    ANXIETY = table.Column<int>(type: "int", nullable: true),
                    OCD = table.Column<int>(type: "int", nullable: true),
                    NPSYDEV = table.Column<int>(type: "int", nullable: true),
                    PSYCDIS = table.Column<int>(type: "int", nullable: true),
                    PSYCDISX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A5s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A5s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEIGHT = table.Column<int>(type: "int", nullable: true),
                    WEIGHT = table.Column<int>(type: "int", nullable: true),
                    BPSYS = table.Column<int>(type: "int", nullable: true),
                    BPDIAS = table.Column<int>(type: "int", nullable: true),
                    HRATE = table.Column<int>(type: "int", nullable: true),
                    VISION = table.Column<int>(type: "int", nullable: true),
                    VISCORR = table.Column<int>(type: "int", nullable: true),
                    VISWCORR = table.Column<int>(type: "int", nullable: true),
                    HEARING = table.Column<int>(type: "int", nullable: true),
                    HEARAID = table.Column<int>(type: "int", nullable: true),
                    HEARWAID = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B4s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORIENT = table.Column<int>(type: "int", nullable: true),
                    JUDGMENT = table.Column<int>(type: "int", nullable: true),
                    COMMUN = table.Column<int>(type: "int", nullable: true),
                    HOMEHOBB = table.Column<int>(type: "int", nullable: true),
                    PERSCARE = table.Column<int>(type: "int", nullable: true),
                    CDRSUM = table.Column<int>(type: "int", nullable: true),
                    CDRGLOB = table.Column<int>(type: "int", nullable: true),
                    COMPORT = table.Column<int>(type: "int", nullable: true),
                    CDRLANG = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B4s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B4s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B5s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NPIQINF = table.Column<int>(type: "int", nullable: true),
                    NPIQINFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DEL = table.Column<int>(type: "int", nullable: true),
                    DELSEV = table.Column<int>(type: "int", nullable: true),
                    HALL = table.Column<int>(type: "int", nullable: true),
                    HALLSEV = table.Column<int>(type: "int", nullable: true),
                    AGIT = table.Column<int>(type: "int", nullable: true),
                    AGITSEV = table.Column<int>(type: "int", nullable: true),
                    DEPD = table.Column<int>(type: "int", nullable: true),
                    DEPDSEV = table.Column<int>(type: "int", nullable: true),
                    ANX = table.Column<int>(type: "int", nullable: true),
                    ANXSEV = table.Column<int>(type: "int", nullable: true),
                    ELAT = table.Column<int>(type: "int", nullable: true),
                    ELATSEV = table.Column<int>(type: "int", nullable: true),
                    APA = table.Column<int>(type: "int", nullable: true),
                    APASEV = table.Column<int>(type: "int", nullable: true),
                    DISN = table.Column<int>(type: "int", nullable: true),
                    DISNSEV = table.Column<int>(type: "int", nullable: true),
                    IRR = table.Column<int>(type: "int", nullable: true),
                    IRRSEV = table.Column<int>(type: "int", nullable: true),
                    MOT = table.Column<int>(type: "int", nullable: true),
                    MOTSEV = table.Column<int>(type: "int", nullable: true),
                    NITE = table.Column<int>(type: "int", nullable: true),
                    NITESEV = table.Column<int>(type: "int", nullable: true),
                    APP = table.Column<int>(type: "int", nullable: true),
                    APPSEV = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B5s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B5s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B6s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOGDS = table.Column<int>(type: "int", nullable: true),
                    SATIS = table.Column<int>(type: "int", nullable: true),
                    DROPACT = table.Column<int>(type: "int", nullable: true),
                    EMPTY = table.Column<int>(type: "int", nullable: true),
                    BORED = table.Column<int>(type: "int", nullable: true),
                    SPIRITS = table.Column<int>(type: "int", nullable: true),
                    AFRAID = table.Column<int>(type: "int", nullable: true),
                    HAPPY = table.Column<int>(type: "int", nullable: true),
                    HELPLESS = table.Column<int>(type: "int", nullable: true),
                    STAYHOME = table.Column<int>(type: "int", nullable: true),
                    MEMPROB = table.Column<int>(type: "int", nullable: true),
                    WONDRFUL = table.Column<int>(type: "int", nullable: true),
                    WRTHLESS = table.Column<int>(type: "int", nullable: true),
                    ENERGY = table.Column<int>(type: "int", nullable: true),
                    HOPELESS = table.Column<int>(type: "int", nullable: true),
                    BETTER = table.Column<int>(type: "int", nullable: true),
                    GDS = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B6s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B6s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B7s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BILLS = table.Column<int>(type: "int", nullable: true),
                    TAXES = table.Column<int>(type: "int", nullable: true),
                    SHOPPING = table.Column<int>(type: "int", nullable: true),
                    GAMES = table.Column<int>(type: "int", nullable: true),
                    STOVE = table.Column<int>(type: "int", nullable: true),
                    MEALPREP = table.Column<int>(type: "int", nullable: true),
                    EVENTS = table.Column<int>(type: "int", nullable: true),
                    PAYATTN = table.Column<int>(type: "int", nullable: true),
                    REMDATES = table.Column<int>(type: "int", nullable: true),
                    TRAVEL = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B7s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B7s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B8s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NORMEXAM = table.Column<int>(type: "int", nullable: true),
                    PARKSIGN = table.Column<int>(type: "int", nullable: true),
                    RESTTRL = table.Column<int>(type: "int", nullable: true),
                    RESTTRR = table.Column<int>(type: "int", nullable: true),
                    SLOWINGL = table.Column<int>(type: "int", nullable: true),
                    SLOWINGR = table.Column<int>(type: "int", nullable: true),
                    RIGIDL = table.Column<int>(type: "int", nullable: true),
                    RIGIDR = table.Column<int>(type: "int", nullable: true),
                    BRADY = table.Column<int>(type: "int", nullable: true),
                    PARKGAIT = table.Column<int>(type: "int", nullable: true),
                    POSTINST = table.Column<int>(type: "int", nullable: true),
                    CVDSIGNS = table.Column<int>(type: "int", nullable: true),
                    CORTDEF = table.Column<int>(type: "int", nullable: true),
                    SIVDFIND = table.Column<int>(type: "int", nullable: true),
                    CVDMOTL = table.Column<int>(type: "int", nullable: true),
                    CVDMOTR = table.Column<int>(type: "int", nullable: true),
                    CORTVISL = table.Column<int>(type: "int", nullable: true),
                    CORTVISR = table.Column<int>(type: "int", nullable: true),
                    SOMATL = table.Column<int>(type: "int", nullable: true),
                    SOMATR = table.Column<int>(type: "int", nullable: true),
                    POSTCORT = table.Column<int>(type: "int", nullable: true),
                    PSPCBS = table.Column<int>(type: "int", nullable: true),
                    EYEPSP = table.Column<int>(type: "int", nullable: true),
                    DYSPSP = table.Column<int>(type: "int", nullable: true),
                    AXIALPSP = table.Column<int>(type: "int", nullable: true),
                    GAITPSP = table.Column<int>(type: "int", nullable: true),
                    APRAXSP = table.Column<int>(type: "int", nullable: true),
                    APRAXL = table.Column<int>(type: "int", nullable: true),
                    APRAXR = table.Column<int>(type: "int", nullable: true),
                    CORTSENL = table.Column<int>(type: "int", nullable: true),
                    CORTSENR = table.Column<int>(type: "int", nullable: true),
                    ATAXL = table.Column<int>(type: "int", nullable: true),
                    ATAXR = table.Column<int>(type: "int", nullable: true),
                    ALIENLML = table.Column<int>(type: "int", nullable: true),
                    ALIENLMR = table.Column<int>(type: "int", nullable: true),
                    DYSTONL = table.Column<int>(type: "int", nullable: true),
                    DYSTONR = table.Column<int>(type: "int", nullable: true),
                    MYOCLLT = table.Column<int>(type: "int", nullable: true),
                    MYOCLRT = table.Column<int>(type: "int", nullable: true),
                    ALSFIND = table.Column<int>(type: "int", nullable: true),
                    GAITNPH = table.Column<int>(type: "int", nullable: true),
                    OTHNEUR = table.Column<int>(type: "int", nullable: true),
                    OTHNEURX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B8s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B8s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B9s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DECSUB = table.Column<int>(type: "int", nullable: true),
                    DECIN = table.Column<int>(type: "int", nullable: true),
                    DECCLCOG = table.Column<int>(type: "int", nullable: true),
                    COGMEM = table.Column<int>(type: "int", nullable: true),
                    COGORI = table.Column<int>(type: "int", nullable: true),
                    COGJUDG = table.Column<int>(type: "int", nullable: true),
                    COGLANG = table.Column<int>(type: "int", nullable: true),
                    COGVIS = table.Column<int>(type: "int", nullable: true),
                    COGATTN = table.Column<int>(type: "int", nullable: true),
                    COGFLUC = table.Column<int>(type: "int", nullable: true),
                    COGFLAGO = table.Column<int>(type: "int", nullable: true),
                    COGOTHR = table.Column<int>(type: "int", nullable: true),
                    COGOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    COGFPRED = table.Column<int>(type: "int", nullable: true),
                    COGFPREX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    COGMODE = table.Column<int>(type: "int", nullable: true),
                    COGMODEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DECAGE = table.Column<int>(type: "int", nullable: true),
                    DECCLBE = table.Column<int>(type: "int", nullable: true),
                    BEAPATHY = table.Column<int>(type: "int", nullable: true),
                    BEDEP = table.Column<int>(type: "int", nullable: true),
                    BEVHALL = table.Column<int>(type: "int", nullable: true),
                    BEVWELL = table.Column<int>(type: "int", nullable: true),
                    BEVHAGO = table.Column<int>(type: "int", nullable: true),
                    BEAHALL = table.Column<int>(type: "int", nullable: true),
                    BEDEL = table.Column<int>(type: "int", nullable: true),
                    BEDISIN = table.Column<int>(type: "int", nullable: true),
                    BEIRRIT = table.Column<int>(type: "int", nullable: true),
                    BEAGIT = table.Column<int>(type: "int", nullable: true),
                    BEPERCH = table.Column<int>(type: "int", nullable: true),
                    BEREM = table.Column<int>(type: "int", nullable: true),
                    BEREMAGO = table.Column<int>(type: "int", nullable: true),
                    BEANX = table.Column<int>(type: "int", nullable: true),
                    BEOTHR = table.Column<int>(type: "int", nullable: true),
                    BEOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BEFPRED = table.Column<int>(type: "int", nullable: true),
                    BEFPREDX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BEMODE = table.Column<int>(type: "int", nullable: true),
                    BEMODEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BEAGE = table.Column<int>(type: "int", nullable: true),
                    DECCLMOT = table.Column<int>(type: "int", nullable: true),
                    MOGAIT = table.Column<int>(type: "int", nullable: true),
                    MOFALLS = table.Column<int>(type: "int", nullable: true),
                    MOTREM = table.Column<int>(type: "int", nullable: true),
                    MOSLOW = table.Column<int>(type: "int", nullable: true),
                    MOFRST = table.Column<int>(type: "int", nullable: true),
                    MOMODE = table.Column<int>(type: "int", nullable: true),
                    MOMODEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MOMOPARK = table.Column<int>(type: "int", nullable: true),
                    PARKAGE = table.Column<int>(type: "int", nullable: true),
                    MOMOALS = table.Column<int>(type: "int", nullable: true),
                    ALSAGE = table.Column<int>(type: "int", nullable: true),
                    MOAGE = table.Column<int>(type: "int", nullable: true),
                    COURSE = table.Column<int>(type: "int", nullable: true),
                    FRSTCHG = table.Column<int>(type: "int", nullable: true),
                    LBDEVAL = table.Column<int>(type: "int", nullable: true),
                    FTLDEVAL = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B9s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B9s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_C1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MMSECOMP = table.Column<int>(type: "int", nullable: true),
                    MMSEREAS = table.Column<int>(type: "int", nullable: true),
                    MMSELOC = table.Column<int>(type: "int", nullable: true),
                    MMSELAN = table.Column<int>(type: "int", nullable: true),
                    MMSELANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MMSEVIS = table.Column<int>(type: "int", nullable: true),
                    MMSEHEAR = table.Column<int>(type: "int", nullable: true),
                    MMSEORDA = table.Column<int>(type: "int", nullable: true),
                    MMSEORLO = table.Column<int>(type: "int", nullable: true),
                    PENTAGON = table.Column<int>(type: "int", nullable: true),
                    MMSE = table.Column<int>(type: "int", nullable: true),
                    NPSYCLOC = table.Column<int>(type: "int", nullable: true),
                    NPSYLAN = table.Column<int>(type: "int", nullable: true),
                    NPSYLANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LOGIMO = table.Column<int>(type: "int", nullable: true),
                    LOGIDAY = table.Column<int>(type: "int", nullable: true),
                    LOGIYR = table.Column<int>(type: "int", nullable: true),
                    LOGIPREV = table.Column<int>(type: "int", nullable: true),
                    LOGIMEM = table.Column<int>(type: "int", nullable: true),
                    UDSBENTC = table.Column<int>(type: "int", nullable: true),
                    DIGIF = table.Column<int>(type: "int", nullable: true),
                    DIGIFLEN = table.Column<int>(type: "int", nullable: true),
                    DIGIB = table.Column<int>(type: "int", nullable: true),
                    DIGIBLEN = table.Column<int>(type: "int", nullable: true),
                    ANIMALS = table.Column<int>(type: "int", nullable: true),
                    VEG = table.Column<int>(type: "int", nullable: true),
                    TRAILA = table.Column<int>(type: "int", nullable: true),
                    TRAILARR = table.Column<int>(type: "int", nullable: true),
                    TRAILALI = table.Column<int>(type: "int", nullable: true),
                    TRAILB = table.Column<int>(type: "int", nullable: true),
                    TRAILBRR = table.Column<int>(type: "int", nullable: true),
                    TRAILBLI = table.Column<int>(type: "int", nullable: true),
                    MEMUNITS = table.Column<int>(type: "int", nullable: true),
                    MEMTIME = table.Column<int>(type: "int", nullable: true),
                    UDSBENTD = table.Column<int>(type: "int", nullable: true),
                    UDSBENRS = table.Column<int>(type: "int", nullable: true),
                    BOSTON = table.Column<int>(type: "int", nullable: true),
                    UDSVERFC = table.Column<int>(type: "int", nullable: true),
                    UDSVERFN = table.Column<int>(type: "int", nullable: true),
                    UDSVERNF = table.Column<int>(type: "int", nullable: true),
                    UDSVERLC = table.Column<int>(type: "int", nullable: true),
                    UDSVERLR = table.Column<int>(type: "int", nullable: true),
                    UDSVERLN = table.Column<int>(type: "int", nullable: true),
                    UDSVERTN = table.Column<int>(type: "int", nullable: true),
                    UDSVERTE = table.Column<int>(type: "int", nullable: true),
                    UDSVERTI = table.Column<int>(type: "int", nullable: true),
                    COGSTAT = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_C1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_C1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_C2s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MOCACOMP = table.Column<int>(type: "int", nullable: true),
                    MOCAREAS = table.Column<int>(type: "int", nullable: true),
                    MOCALOC = table.Column<int>(type: "int", nullable: true),
                    MOCALAN = table.Column<int>(type: "int", nullable: true),
                    MOCALANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MOCAVIS = table.Column<int>(type: "int", nullable: true),
                    MOCAHEAR = table.Column<int>(type: "int", nullable: true),
                    MOCATOTS = table.Column<int>(type: "int", nullable: true),
                    MOCATRAI = table.Column<int>(type: "int", nullable: true),
                    MOCACUBE = table.Column<int>(type: "int", nullable: true),
                    MOCACLOC = table.Column<int>(type: "int", nullable: true),
                    MOCACLON = table.Column<int>(type: "int", nullable: true),
                    MOCACLOH = table.Column<int>(type: "int", nullable: true),
                    MOCANAMI = table.Column<int>(type: "int", nullable: true),
                    MOCAREGI = table.Column<int>(type: "int", nullable: true),
                    MOCADIGI = table.Column<int>(type: "int", nullable: true),
                    MOCALETT = table.Column<int>(type: "int", nullable: true),
                    MOCASER7 = table.Column<int>(type: "int", nullable: true),
                    MOCAREPE = table.Column<int>(type: "int", nullable: true),
                    MOCAFLUE = table.Column<int>(type: "int", nullable: true),
                    MOCAABST = table.Column<int>(type: "int", nullable: true),
                    MOCARECN = table.Column<int>(type: "int", nullable: true),
                    MOCARECC = table.Column<int>(type: "int", nullable: true),
                    MOCARECR = table.Column<int>(type: "int", nullable: true),
                    MOCAORDT = table.Column<int>(type: "int", nullable: true),
                    MOCAORMO = table.Column<int>(type: "int", nullable: true),
                    MOCAORYR = table.Column<int>(type: "int", nullable: true),
                    MOCAORDY = table.Column<int>(type: "int", nullable: true),
                    MOCAORPL = table.Column<int>(type: "int", nullable: true),
                    MOCAORCT = table.Column<int>(type: "int", nullable: true),
                    NPSYCLOC = table.Column<int>(type: "int", nullable: true),
                    NPSYLAN = table.Column<int>(type: "int", nullable: true),
                    NPSYLANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CRAFTVRS = table.Column<int>(type: "int", nullable: true),
                    CRAFTURS = table.Column<int>(type: "int", nullable: true),
                    UDSBENTC = table.Column<int>(type: "int", nullable: true),
                    DIGFORCT = table.Column<int>(type: "int", nullable: true),
                    DIGFORSL = table.Column<int>(type: "int", nullable: true),
                    DIGBACCT = table.Column<int>(type: "int", nullable: true),
                    DIGBACLS = table.Column<int>(type: "int", nullable: true),
                    ANIMALS = table.Column<int>(type: "int", nullable: true),
                    VEG = table.Column<int>(type: "int", nullable: true),
                    TRAILA = table.Column<int>(type: "int", nullable: true),
                    TRAILARR = table.Column<int>(type: "int", nullable: true),
                    TRAILALI = table.Column<int>(type: "int", nullable: true),
                    TRAILB = table.Column<int>(type: "int", nullable: true),
                    TRAILBRR = table.Column<int>(type: "int", nullable: true),
                    TRAILBLI = table.Column<int>(type: "int", nullable: true),
                    CRAFTDVR = table.Column<int>(type: "int", nullable: true),
                    CRAFTDRE = table.Column<int>(type: "int", nullable: true),
                    CRAFTDTI = table.Column<int>(type: "int", nullable: true),
                    CRAFTCUE = table.Column<int>(type: "int", nullable: true),
                    UDSBENTD = table.Column<int>(type: "int", nullable: true),
                    UDSBENRS = table.Column<int>(type: "int", nullable: true),
                    MINTTOTS = table.Column<int>(type: "int", nullable: true),
                    MINTTOTW = table.Column<int>(type: "int", nullable: true),
                    MINTSCNG = table.Column<int>(type: "int", nullable: true),
                    MINTSCNC = table.Column<int>(type: "int", nullable: true),
                    MINTPCNG = table.Column<int>(type: "int", nullable: true),
                    MINTPCNC = table.Column<int>(type: "int", nullable: true),
                    UDSVERFC = table.Column<int>(type: "int", nullable: true),
                    UDSVERFN = table.Column<int>(type: "int", nullable: true),
                    UDSVERNF = table.Column<int>(type: "int", nullable: true),
                    UDSVERLC = table.Column<int>(type: "int", nullable: true),
                    UDSVERLR = table.Column<int>(type: "int", nullable: true),
                    UDSVERLN = table.Column<int>(type: "int", nullable: true),
                    UDSVERTN = table.Column<int>(type: "int", nullable: true),
                    UDSVERTE = table.Column<int>(type: "int", nullable: true),
                    UDSVERTI = table.Column<int>(type: "int", nullable: true),
                    COGSTAT = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_C2s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_C2s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_D1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DXMETHOD = table.Column<int>(type: "int", nullable: true),
                    NORMCOG = table.Column<int>(type: "int", nullable: true),
                    DEMENTED = table.Column<int>(type: "int", nullable: true),
                    AMNDEM = table.Column<int>(type: "int", nullable: true),
                    PCA = table.Column<int>(type: "int", nullable: true),
                    PPASYN = table.Column<int>(type: "int", nullable: true),
                    PPASYNT = table.Column<int>(type: "int", nullable: true),
                    FTDSYN = table.Column<int>(type: "int", nullable: true),
                    LBDSYN = table.Column<int>(type: "int", nullable: true),
                    NAMNDEM = table.Column<int>(type: "int", nullable: true),
                    MCIAMEM = table.Column<int>(type: "int", nullable: true),
                    MCIAPLUS = table.Column<int>(type: "int", nullable: true),
                    MCIAPLAN = table.Column<int>(type: "int", nullable: true),
                    MCIAPATT = table.Column<int>(type: "int", nullable: true),
                    MCIAPEX = table.Column<int>(type: "int", nullable: true),
                    MCIAPVIS = table.Column<int>(type: "int", nullable: true),
                    MCINON1 = table.Column<int>(type: "int", nullable: true),
                    MCIN1LAN = table.Column<int>(type: "int", nullable: true),
                    MCIN1ATT = table.Column<int>(type: "int", nullable: true),
                    MCIN1EX = table.Column<int>(type: "int", nullable: true),
                    MCIN1VIS = table.Column<int>(type: "int", nullable: true),
                    MCINON2 = table.Column<int>(type: "int", nullable: true),
                    MCIN2LAN = table.Column<int>(type: "int", nullable: true),
                    MCIN2ATT = table.Column<int>(type: "int", nullable: true),
                    MCIN2EX = table.Column<int>(type: "int", nullable: true),
                    MCIN2VIS = table.Column<int>(type: "int", nullable: true),
                    IMPNOMCI = table.Column<int>(type: "int", nullable: true),
                    AMYLPET = table.Column<int>(type: "int", nullable: true),
                    AMYLCSF = table.Column<int>(type: "int", nullable: true),
                    FDGAD = table.Column<int>(type: "int", nullable: true),
                    HIPPATR = table.Column<int>(type: "int", nullable: true),
                    TAUPETAD = table.Column<int>(type: "int", nullable: true),
                    CSFTAU = table.Column<int>(type: "int", nullable: true),
                    FDGFTLD = table.Column<int>(type: "int", nullable: true),
                    TPETFTLD = table.Column<int>(type: "int", nullable: true),
                    MRFTLD = table.Column<int>(type: "int", nullable: true),
                    DATSCAN = table.Column<int>(type: "int", nullable: true),
                    OTHBIOM = table.Column<int>(type: "int", nullable: true),
                    OTHBIOMX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IMAGLINF = table.Column<int>(type: "int", nullable: true),
                    IMAGLAC = table.Column<int>(type: "int", nullable: true),
                    IMAGMACH = table.Column<int>(type: "int", nullable: true),
                    IMAGMICH = table.Column<int>(type: "int", nullable: true),
                    IMAGMWMH = table.Column<int>(type: "int", nullable: true),
                    IMAGEWMH = table.Column<int>(type: "int", nullable: true),
                    ADMUT = table.Column<int>(type: "int", nullable: true),
                    FTLDMUT = table.Column<int>(type: "int", nullable: true),
                    OTHMUT = table.Column<int>(type: "int", nullable: true),
                    OTHMUTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ALZDIS = table.Column<int>(type: "int", nullable: true),
                    ALZDISIF = table.Column<int>(type: "int", nullable: true),
                    LBDIS = table.Column<int>(type: "int", nullable: true),
                    LBDIF = table.Column<int>(type: "int", nullable: true),
                    PARK = table.Column<int>(type: "int", nullable: true),
                    MSA = table.Column<int>(type: "int", nullable: true),
                    MSAIF = table.Column<int>(type: "int", nullable: true),
                    PSP = table.Column<int>(type: "int", nullable: true),
                    PSPIF = table.Column<int>(type: "int", nullable: true),
                    CORT = table.Column<int>(type: "int", nullable: true),
                    CORTIF = table.Column<int>(type: "int", nullable: true),
                    FTLDMO = table.Column<int>(type: "int", nullable: true),
                    FTLDMOIF = table.Column<int>(type: "int", nullable: true),
                    FTLDNOS = table.Column<int>(type: "int", nullable: true),
                    FTLDNOIF = table.Column<int>(type: "int", nullable: true),
                    FTLDSUBT = table.Column<int>(type: "int", nullable: true),
                    FTLDSUBX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CVD = table.Column<int>(type: "int", nullable: true),
                    CVDIF = table.Column<int>(type: "int", nullable: true),
                    PREVSTK = table.Column<int>(type: "int", nullable: true),
                    STROKDEC = table.Column<int>(type: "int", nullable: true),
                    STKIMAG = table.Column<int>(type: "int", nullable: true),
                    INFNETW = table.Column<int>(type: "int", nullable: true),
                    INFWMH = table.Column<int>(type: "int", nullable: true),
                    ESSTREM = table.Column<int>(type: "int", nullable: true),
                    ESSTREIF = table.Column<int>(type: "int", nullable: true),
                    DOWNS = table.Column<int>(type: "int", nullable: true),
                    DOWNSIF = table.Column<int>(type: "int", nullable: true),
                    HUNT = table.Column<int>(type: "int", nullable: true),
                    HUNTIF = table.Column<int>(type: "int", nullable: true),
                    PRION = table.Column<int>(type: "int", nullable: true),
                    PRIONIF = table.Column<int>(type: "int", nullable: true),
                    BRNINJ = table.Column<int>(type: "int", nullable: true),
                    BRNINJIF = table.Column<int>(type: "int", nullable: true),
                    BRNINCTE = table.Column<int>(type: "int", nullable: true),
                    HYCEPH = table.Column<int>(type: "int", nullable: true),
                    HYCEPHIF = table.Column<int>(type: "int", nullable: true),
                    EPILEP = table.Column<int>(type: "int", nullable: true),
                    EPILEPIF = table.Column<int>(type: "int", nullable: true),
                    NEOP = table.Column<int>(type: "int", nullable: true),
                    NEOPIF = table.Column<int>(type: "int", nullable: true),
                    NEOPSTAT = table.Column<int>(type: "int", nullable: true),
                    HIV = table.Column<int>(type: "int", nullable: true),
                    HIVIF = table.Column<int>(type: "int", nullable: true),
                    OTHCOG = table.Column<int>(type: "int", nullable: true),
                    OTHCOGIF = table.Column<int>(type: "int", nullable: true),
                    OTHCOGX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DEP = table.Column<int>(type: "int", nullable: true),
                    DEPIF = table.Column<int>(type: "int", nullable: true),
                    DEPTREAT = table.Column<int>(type: "int", nullable: true),
                    BIPOLDX = table.Column<int>(type: "int", nullable: true),
                    BIPOLDIF = table.Column<int>(type: "int", nullable: true),
                    SCHIZOP = table.Column<int>(type: "int", nullable: true),
                    SCHIZOIF = table.Column<int>(type: "int", nullable: true),
                    ANXIET = table.Column<int>(type: "int", nullable: true),
                    ANXIETIF = table.Column<int>(type: "int", nullable: true),
                    DELIR = table.Column<int>(type: "int", nullable: true),
                    DELIRIF = table.Column<int>(type: "int", nullable: true),
                    PTSDDX = table.Column<int>(type: "int", nullable: true),
                    PTSDDXIF = table.Column<int>(type: "int", nullable: true),
                    OTHPSY = table.Column<int>(type: "int", nullable: true),
                    OTHPSYIF = table.Column<int>(type: "int", nullable: true),
                    OTHPSYX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ALCDEM = table.Column<int>(type: "int", nullable: true),
                    ALCDEMIF = table.Column<int>(type: "int", nullable: true),
                    ALCABUSE = table.Column<int>(type: "int", nullable: true),
                    IMPSUB = table.Column<int>(type: "int", nullable: true),
                    IMPSUBIF = table.Column<int>(type: "int", nullable: true),
                    DYSILL = table.Column<int>(type: "int", nullable: true),
                    DYSILLIF = table.Column<int>(type: "int", nullable: true),
                    MEDS = table.Column<int>(type: "int", nullable: true),
                    MEDSIF = table.Column<int>(type: "int", nullable: true),
                    COGOTH = table.Column<int>(type: "int", nullable: true),
                    COGOTHIF = table.Column<int>(type: "int", nullable: true),
                    COGOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    COGOTH2 = table.Column<int>(type: "int", nullable: true),
                    COGOTH2F = table.Column<int>(type: "int", nullable: true),
                    COGOTH2X = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    COGOTH3 = table.Column<int>(type: "int", nullable: true),
                    COGOTH3F = table.Column<int>(type: "int", nullable: true),
                    COGOTH3X = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_D1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_D1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_D2s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CANCER = table.Column<int>(type: "int", nullable: true),
                    CANCSITE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIABET = table.Column<int>(type: "int", nullable: true),
                    MYOINF = table.Column<int>(type: "int", nullable: true),
                    CONGHRT = table.Column<int>(type: "int", nullable: true),
                    AFIBRILL = table.Column<int>(type: "int", nullable: true),
                    HYPERT = table.Column<int>(type: "int", nullable: true),
                    ANGINA = table.Column<int>(type: "int", nullable: true),
                    HYPCHOL = table.Column<int>(type: "int", nullable: true),
                    VB12DEF = table.Column<int>(type: "int", nullable: true),
                    THYDIS = table.Column<int>(type: "int", nullable: true),
                    ARTH = table.Column<int>(type: "int", nullable: true),
                    ARTYPE = table.Column<int>(type: "int", nullable: true),
                    ARTYPEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ARTUPEX = table.Column<int>(type: "int", nullable: true),
                    ARTLOEX = table.Column<int>(type: "int", nullable: true),
                    ARTSPIN = table.Column<int>(type: "int", nullable: true),
                    ARTUNKN = table.Column<int>(type: "int", nullable: true),
                    URINEINC = table.Column<int>(type: "int", nullable: true),
                    BOWLINC = table.Column<int>(type: "int", nullable: true),
                    SLEEPAP = table.Column<int>(type: "int", nullable: true),
                    REMDIS = table.Column<int>(type: "int", nullable: true),
                    HYPOSOM = table.Column<int>(type: "int", nullable: true),
                    SLEEPOTH = table.Column<int>(type: "int", nullable: true),
                    SLEEPOTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ANGIOCP = table.Column<int>(type: "int", nullable: true),
                    ANGIOPCI = table.Column<int>(type: "int", nullable: true),
                    PACEMAKE = table.Column<int>(type: "int", nullable: true),
                    HVALVE = table.Column<int>(type: "int", nullable: true),
                    ANTIENC = table.Column<int>(type: "int", nullable: true),
                    ANTIENCX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    OTHCOND = table.Column<int>(type: "int", nullable: true),
                    OTHCONDX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_D2s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_D2s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_T1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TELCOG = table.Column<int>(type: "int", nullable: true),
                    TELILL = table.Column<int>(type: "int", nullable: true),
                    TELHOME = table.Column<int>(type: "int", nullable: true),
                    TELREFU = table.Column<int>(type: "int", nullable: true),
                    TELCOV = table.Column<int>(type: "int", nullable: true),
                    TELOTHR = table.Column<int>(type: "int", nullable: true),
                    TELOTHRX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TELMOD = table.Column<int>(type: "int", nullable: true),
                    TELINPER = table.Column<int>(type: "int", nullable: true),
                    TELMILE = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_T1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_T1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A1s_VisitId",
                table: "tbl_A1s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A2s_VisitId",
                table: "tbl_A2s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A3s_VisitId",
                table: "tbl_A3s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4Ds_VisitId",
                table: "tbl_A4Ds",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4Gs_VisitId",
                table: "tbl_A4Gs",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A5s_VisitId",
                table: "tbl_A5s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B1s_VisitId",
                table: "tbl_B1s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B4s_VisitId",
                table: "tbl_B4s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B5s_VisitId",
                table: "tbl_B5s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B6s_VisitId",
                table: "tbl_B6s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B7s_VisitId",
                table: "tbl_B7s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B8s_VisitId",
                table: "tbl_B8s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B9s_VisitId",
                table: "tbl_B9s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_C1s_VisitId",
                table: "tbl_C1s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_C2s_VisitId",
                table: "tbl_C2s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_D1s_VisitId",
                table: "tbl_D1s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_D2s_VisitId",
                table: "tbl_D2s",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_M1s_ParticipationId",
                table: "tbl_M1s",
                column: "ParticipationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_T1s_VisitId",
                table: "tbl_T1s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Visits_ParticipationId_Number",
                table: "tbl_Visits",
                columns: new[] { "ParticipationId", "Number" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_A1s");

            migrationBuilder.DropTable(
                name: "tbl_A2s");

            migrationBuilder.DropTable(
                name: "tbl_A3s");

            migrationBuilder.DropTable(
                name: "tbl_A4Ds");

            migrationBuilder.DropTable(
                name: "tbl_A4Gs");

            migrationBuilder.DropTable(
                name: "tbl_A5s");

            migrationBuilder.DropTable(
                name: "tbl_B1s");

            migrationBuilder.DropTable(
                name: "tbl_B4s");

            migrationBuilder.DropTable(
                name: "tbl_B5s");

            migrationBuilder.DropTable(
                name: "tbl_B6s");

            migrationBuilder.DropTable(
                name: "tbl_B7s");

            migrationBuilder.DropTable(
                name: "tbl_B8s");

            migrationBuilder.DropTable(
                name: "tbl_B9s");

            migrationBuilder.DropTable(
                name: "tbl_C1s");

            migrationBuilder.DropTable(
                name: "tbl_C2s");

            migrationBuilder.DropTable(
                name: "tbl_D1s");

            migrationBuilder.DropTable(
                name: "tbl_D2s");

            migrationBuilder.DropTable(
                name: "tbl_M1s");

            migrationBuilder.DropTable(
                name: "tbl_T1s");

            migrationBuilder.DropTable(
                name: "tbl_Visits");

            migrationBuilder.DropTable(
                name: "Participation");
        }
    }
}
