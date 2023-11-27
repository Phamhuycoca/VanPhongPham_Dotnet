using AutoMapper;
using Model.Dto;
using Model.Model;
using Repository.IRepo;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class LoaiSanPhamService : ILoaiSanPhamService
    {
        private readonly ILoaiSanPhamRepo _loaiSanPham;
        private readonly IMapper _mapper;
        public LoaiSanPhamService(ILoaiSanPhamRepo loaiSanPham, IMapper mapper)
        {
            _loaiSanPham = loaiSanPham;
            _mapper = mapper;
        }

        public bool Create(LoaiSanPhamDto loaisanpham)
        {
            return _loaiSanPham.Add(_mapper.Map<LoaiSanPham>(loaisanpham));
        }

        public bool Delete(int id)
        {
            return _loaiSanPham.Delete(id);
        }

        public LoaiSanPhamDto GetById(int id)
        {
            return _mapper.Map<LoaiSanPhamDto>(_loaiSanPham.Get(id));
        }

        public List<LoaiSanPhamDto> Index()
        {
            return _mapper.Map<List<LoaiSanPhamDto>>(_loaiSanPham.GetAll());
        }

        public bool Update(LoaiSanPhamDto loaisanpham)
        {
            return _loaiSanPham.Update(_mapper.Map<LoaiSanPham>(loaisanpham));
        }
    }
}
