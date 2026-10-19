using System;

namespace FormChiTieu.Models
{
    public class ChiTieuViewModel
    {
        public int MaCt { get; set; }
        public string MaHienThi => MaCt.ToString("D3");
        public DateOnly NgayChi { get; set; }
        public string NgayChiHienThi => NgayChi.ToString("dd/MM/yyyy");
        public string NoiDung { get; set; } = string.Empty;
        public string LoaiChi { get; set; } = string.Empty;
        public decimal SoTien { get; set; }
        public string SoTienHienThi => SoTien.ToString("N0");
        public string? GhiChu { get; set; }
    }
}
