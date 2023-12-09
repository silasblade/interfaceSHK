using System.ComponentModel.DataAnnotations;

namespace QLHK.Core6.Models
{
    public class NhanKhau
    {


        [Key][Required] public string MaNhanKhau { get; set; } = string.Empty;
        public string? MaHoKhau { get; set; } = string.Empty;
        public string HoVaTen { get; set; } = string.Empty;
        public string GioiTinh { get; set; } = string.Empty;
        public int NamSinh { get; set; }
        public string QHVoiChuHo { get; set; } = string.Empty;
        public string NoiSinh { get; set; } = string.Empty;
        public string QueQuan { get; set; } = string.Empty;
        public string DanToc { get; set; } = string.Empty;
        public string NgheNghiep { get; set; } = string.Empty;
        public string NoiLamViec { get; set; } = string.Empty;
        public string CCCD { get; set; } = string.Empty;
        public string imageurl {  get; set; } = string.Empty;
    }
}
