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
    public class ChiTietDonHangService:IChiTietDonHangService
    {
        private readonly IChiTietDonHangRepo _chiTietDonHangRepo;
        private readonly IMapper _mapper;
        public ChiTietDonHangService(IChiTietDonHangRepo chiTietDonHangRepo, IMapper mapper)
        {
            _chiTietDonHangRepo = chiTietDonHangRepo;
            _mapper = mapper;
        }

        public bool Create(ChiTietDonHangDto chitietdonhang)
        {
            return _chiTietDonHangRepo.Add(_mapper.Map<ChiTietDonHang>(chitietdonhang));
        }

        public bool Delete(int id)
        {
            return _chiTietDonHangRepo.Delete(id);
        }

        public ChiTietDonHangDto GetById(int id)
        {
            return _mapper.Map<ChiTietDonHangDto>(_chiTietDonHangRepo.Get(id));
        }

        public List<ChiTietDonHangDto> Index()
        {
            return _mapper.Map<List<ChiTietDonHangDto>>(_chiTietDonHangRepo.GetAll());
        }

        public bool Update(ChiTietDonHangDto chitietdonhang)
        {
            return _chiTietDonHangRepo.Update(_mapper.Map<ChiTietDonHang>(chitietdonhang));
        }
    }
}
