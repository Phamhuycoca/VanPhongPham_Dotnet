using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IDonHangService
    {
        List<DonHangDto> Index();
        DonHangDto GetById(int id);
        bool Create(DonHangDto donhang);
        bool Update(DonHangDto donhang);
        bool Delete(int id);
    }
}
