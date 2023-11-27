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
    public class DonHangService:IDonHangService
    {
        private readonly IDonHangRepo _donHangRepo;
        private readonly IMapper _mapper;
        public DonHangService(IDonHangRepo donHangRepo, IMapper mapper)
        {
            _donHangRepo = donHangRepo;
            _mapper = mapper;
        }

        public bool Create(DonHangDto donhang)
        {
            return _donHangRepo.Add(_mapper.Map<DonHang>(donhang));
        }

        public bool Delete(int id)
        {
            return _donHangRepo.Delete(id);
        }

        public DonHangDto GetById(int id)
        {
            return _mapper.Map<DonHangDto>(_donHangRepo.Get(id));
        }

        public List<DonHangDto> Index()
        {
            return _mapper.Map<List<DonHangDto>>(_donHangRepo.GetAll());
        }

        public bool Update(DonHangDto donhang)
        {
            return _donHangRepo.Update(_mapper.Map<DonHang>(donhang));
        }
    }
}
