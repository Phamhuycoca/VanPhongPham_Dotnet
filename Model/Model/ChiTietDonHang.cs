using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class ChiTietDonHang
    {
        public int ChiTietDonHangId { get; set; }
        public int DonHangId { get; set; }
        public int SanPhamId { get; set; }
        public int SanPhamGia {  get; set; }
        public int SoLuong {  get; set; }
        public DonHang? donHang {  get; set; }
        public SanPham? sanPham { get; set;}
    }
}
