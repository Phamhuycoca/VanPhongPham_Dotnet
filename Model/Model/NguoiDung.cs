using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class NguoiDung
    {
        public int NguoiDungId {  get; set; }
        public string? HoTen {  get; set; }
        public string? HinhAnh {  get; set; }
        public string? DiaChi {  get; set; }
        public string? Sdt {  get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool isAdmin { get; set; }
        public ICollection<DonHang>? donHangs {  get; set; }
    }
}
