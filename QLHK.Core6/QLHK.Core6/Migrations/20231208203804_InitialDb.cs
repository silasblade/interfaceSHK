using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHK.Core6.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanKhaus",
                columns: table => new
                {
                    MaNhanKhau = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaHoKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamSinh = table.Column<int>(type: "int", nullable: false),
                    QHVoiChuHo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiSinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DanToc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiLamViec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageurl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanKhaus", x => x.MaNhanKhau);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanKhaus_MaNhanKhau",
                table: "NhanKhaus",
                column: "MaNhanKhau",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanKhaus");
        }
    }
}
