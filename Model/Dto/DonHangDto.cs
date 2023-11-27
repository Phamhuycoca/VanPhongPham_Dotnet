using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class DonHangDto
    {
        public int DonHangId { get; set; }
        public int NguoiDungId { get; set; }
        public string? NgayTao { get; set; }
        public int TongTien { get; set; }
        public int TrangThai { get; set; }
    }
}
