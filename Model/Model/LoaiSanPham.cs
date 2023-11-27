using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class LoaiSanPham
    {
        public int LoaiSanPhamId { get; set; }
        public string? TenLoaiSanPham {  get; set; }
        public ICollection<SanPham>? sanPhams { get; set; }
    }
}
