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
    public class SanPhamService:ISanPhamService
    {
        private readonly ISanPhamRepo _sanPhamRepo;
        private readonly IMapper _mapper;
        public SanPhamService(ISanPhamRepo sanPhamRepo, IMapper mapper)
        {
            _sanPhamRepo = sanPhamRepo;
            _mapper = mapper;
        }

        public bool Create(SanPhamDto sanpham)
        {
            return _sanPhamRepo.Add(_mapper.Map<SanPham>(sanpham));
        }

        public bool Delete(int id)
        {
            return _sanPhamRepo.Delete(id);
        }

        public SanPhamDto GetById(int id)
        {
            return _mapper.Map<SanPhamDto>(_sanPhamRepo.Get(id));
        }

        public List<SanPhamDto> Index()
        {
            return _mapper.Map<List<SanPhamDto>>(_sanPhamRepo.GetAll());
        }

        public bool Update(SanPhamDto sanpham)
        {
            return _sanPhamRepo.Update(_mapper.Map<SanPham>(sanpham));
        }
    }
}
