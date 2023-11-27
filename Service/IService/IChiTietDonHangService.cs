using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IChiTietDonHangService
    {
        List<ChiTietDonHangDto> Index();
        ChiTietDonHangDto GetById(int id);
        bool Create(ChiTietDonHangDto chitietdonhang);
        bool Update(ChiTietDonHangDto chitietdonhang);
        bool Delete(int id);
    }
}
