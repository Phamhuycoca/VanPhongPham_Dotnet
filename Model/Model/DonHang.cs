using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class DonHang
    {
        public int DonHangId {  get; set; }
        public int NguoiDungId {  get; set; }
        public string? NgayTao { get; set; }
        public int TongTien {  get; set; }
        public int TrangThai {  get; set; }
        public NguoiDung? nguoiDung { get; set; }
        public ICollection<ChiTietDonHang>? chiTietDonHangs { get; set; }
    }
}
