using AutoMapper;
using Model.Dto;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<LoaiSanPham, LoaiSanPhamDto>().ReverseMap();
            CreateMap<DonHang, DonHangDto>().ReverseMap();
            CreateMap<SanPham, SanPhamDto>().ReverseMap();
            CreateMap<NguoiDung, NguoiDungDto>().ReverseMap();
            CreateMap<ChiTietDonHang,ChiTietDonHangDto>().ReverseMap();
        }
    }
}
