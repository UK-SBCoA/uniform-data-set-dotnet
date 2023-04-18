using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSQLViewsForFormStatuses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW vw_FormStatuses
                AS
                SELECT a1.[FormId], a1.[VisitId], a1.[Status], a1.[LANG], a1.[SUB], a1.[NOT], 'A1' as Kind, a1.[CreatedAt], a1.[CreatedBy], a1.[ModifiedBy], a1.[DeletedBy], a1.[IsDeleted]
                FROM dbo.tbl_A1s as a1
                UNION
                SELECT a2.[FormId], a2.[VisitId], a2.[Status], a2.[LANG], a2.[SUB], a2.[NOT], 'A2' as Kind, a2.[CreatedAt], a2.[CreatedBy], a2.[ModifiedBy], a2.[DeletedBy], a2.[IsDeleted]
                FROM dbo.tbl_A2s as a2
                UNION
                SELECT a3.[FormId], a3.[VisitId], a3.[Status], a3.[LANG], a3.[SUB], a3.[NOT], 'A3' as Kind, a3.[CreatedAt], a3.[CreatedBy], a3.[ModifiedBy], a3.[DeletedBy], a3.[IsDeleted]
                FROM dbo.tbl_A3s as a3
                UNION
                SELECT a4.[FormId], a4.[VisitId], a4.[Status], a4.[LANG], a4.[SUB], a4.[NOT], 'A4' as Kind, a4.[CreatedAt], a4.[CreatedBy], a4.[ModifiedBy], a4.[DeletedBy], a4.[IsDeleted]
                FROM dbo.tbl_A4Gs as a4
                UNION
                SELECT a5.[FormId], a5.[VisitId], a5.[Status], a5.[LANG], a5.[SUB], a5.[NOT], 'A5' as Kind, a5.[CreatedAt], a5.[CreatedBy], a5.[ModifiedBy], a5.[DeletedBy], a5.[IsDeleted]
                FROM dbo.tbl_A5s as a5
                UNION
                SELECT b1.[FormId], b1.[VisitId], b1.[Status], b1.[LANG], b1.[SUB], b1.[NOT], 'B1' as Kind, b1.[CreatedAt], b1.[CreatedBy], b1.[ModifiedBy], b1.[DeletedBy], b1.[IsDeleted]
                FROM dbo.tbl_B1s as b1
                UNION
                SELECT b4.[FormId], b4.[VisitId], b4.[Status], b4.[LANG], b4.[SUB], b4.[NOT], 'B4' as Kind, b4.[CreatedAt], b4.[CreatedBy], b4.[ModifiedBy], b4.[DeletedBy], b4.[IsDeleted]
                FROM dbo.tbl_B4s as b4
                UNION
                SELECT b5.[FormId], b5.[VisitId], b5.[Status], b5.[LANG], b5.[SUB], b5.[NOT], 'B5' as Kind, b5.[CreatedAt], b5.[CreatedBy], b5.[ModifiedBy], b5.[DeletedBy], b5.[IsDeleted]
                FROM dbo.tbl_B5s as b5
                UNION
                SELECT b6.[FormId], b6.[VisitId], b6.[Status], b6.[LANG], b6.[SUB], b6.[NOT], 'B6' as Kind, b6.[CreatedAt], b6.[CreatedBy], b6.[ModifiedBy], b6.[DeletedBy], b6.[IsDeleted]
                FROM dbo.tbl_B6s as b6
                UNION
                SELECT b7.[FormId], b7.[VisitId], b7.[Status], b7.[LANG], b7.[SUB], b7.[NOT], 'B7' as Kind, b7.[CreatedAt], b7.[CreatedBy], b7.[ModifiedBy], b7.[DeletedBy], b7.[IsDeleted]
                FROM dbo.tbl_B7s as b7
                UNION
                SELECT b8.[FormId], b8.[VisitId], b8.[Status], b8.[LANG], b8.[SUB], b8.[NOT], 'B8' as Kind, b8.[CreatedAt], b8.[CreatedBy], b8.[ModifiedBy], b8.[DeletedBy], b8.[IsDeleted]
                FROM dbo.tbl_B8s as b8
                UNION
                SELECT b9.[FormId], b9.[VisitId], b9.[Status], b9.[LANG], b9.[SUB], b9.[NOT], 'B9' as Kind, b9.[CreatedAt], b9.[CreatedBy], b9.[ModifiedBy], b9.[DeletedBy], b9.[IsDeleted]
                FROM dbo.tbl_B9s as b9
                UNION
                SELECT c1.[FormId], c1.[VisitId], c1.[Status], c1.[LANG], c1.[SUB], c1.[NOT], 'C1' as Kind, c1.[CreatedAt], c1.[CreatedBy], c1.[ModifiedBy], c1.[DeletedBy], c1.[IsDeleted]
                FROM dbo.tbl_C1s as c1
                UNION
                SELECT c2.[FormId], c2.[VisitId], c2.[Status], c2.[LANG], c2.[SUB], c2.[NOT], 'C2' as Kind, c2.[CreatedAt], c2.[CreatedBy], c2.[ModifiedBy], c2.[DeletedBy], c2.[IsDeleted]
                FROM dbo.tbl_C2s as c2
                UNION
                SELECT d1.[FormId], d1.[VisitId], d1.[Status], d1.[LANG], d1.[SUB], d1.[NOT], 'D1' as Kind, d1.[CreatedAt], d1.[CreatedBy], d1.[ModifiedBy], d1.[DeletedBy], d1.[IsDeleted]
                FROM dbo.tbl_D1s as d1
                UNION
                SELECT d2.[FormId], d2.[VisitId], d2.[Status], d2.[LANG], d2.[SUB], d2.[NOT], 'D2' as Kind, d2.[CreatedAt], d2.[CreatedBy], d2.[ModifiedBy], d2.[DeletedBy], d2.[IsDeleted]
                FROM dbo.tbl_D2s as d2
                UNION
                SELECT t1.[FormId], t1.[VisitId], t1.[Status], t1.[LANG], t1.[SUB], t1.[NOT], 'T1' as Kind, t1.[CreatedAt], t1.[CreatedBy], t1.[ModifiedBy], t1.[DeletedBy], t1.[IsDeleted]
                FROM dbo.tbl_T1s as t1;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DROP VIEW dbo.vw_FormStatuses;
            ");
        }
    }
}
