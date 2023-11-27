using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface INguoiDungService
    {
        List<NguoiDungDto> Index();
        NguoiDungDto GetById(int id);
        bool Create(NguoiDungDto nguoidung);
        bool Update(NguoiDungDto nguoidung);
        bool Delete(int id);
    }
}
