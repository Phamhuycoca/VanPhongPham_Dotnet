using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ISanPhamService
    {
        List<SanPhamDto> Index();
        SanPhamDto GetById(int id);
        bool Create(SanPhamDto sanpham);
        bool Update(SanPhamDto sanpham);
        bool Delete(int id);
    }
}
