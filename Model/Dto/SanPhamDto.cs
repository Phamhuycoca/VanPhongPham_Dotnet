using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
    public class SanPhamDto
    {
        public int SanPhamId { get; set; }
        public string? SanPhamTen { get; set; }
        public string? SanPhamHinhAnh { get; set; }
        public int SanPhamGia { get; set; }
        public string? SanPhamNguonGoc { get; set; }
        public int LoaiSanPhamId { get; set; }
    }
}
