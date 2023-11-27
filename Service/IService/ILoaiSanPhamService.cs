using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ILoaiSanPhamService
    {
        List<LoaiSanPhamDto> Index();
        LoaiSanPhamDto GetById(int id);
        bool Create(LoaiSanPhamDto loaisanpham);
        bool Update(LoaiSanPhamDto loaisanpham);
        bool Delete(int id);
    }
}
