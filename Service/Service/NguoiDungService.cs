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
    public class NguoiDungService : INguoiDungService
    {
        private readonly INguoiDungRepo _nguoiDungRepo;
        private readonly IMapper _mapper;
        public NguoiDungService(INguoiDungRepo nguoiDungRepo, IMapper mapper)
        {
            _nguoiDungRepo = nguoiDungRepo;
            _mapper = mapper;
        }

        public bool Create(NguoiDungDto nguoidung)
        {
            return _nguoiDungRepo.Add(_mapper.Map<NguoiDung>(nguoidung));
        }

        public bool Delete(int id)
        {
            return _nguoiDungRepo.Delete(id);
        }

        public NguoiDungDto GetById(int id)
        {
            return _mapper.Map<NguoiDungDto>(_nguoiDungRepo.Get(id));
        }

        public List<NguoiDungDto> Index()
        {
            return _mapper.Map<List<NguoiDungDto>>(_nguoiDungRepo.GetAll());
        }

        public bool Update(NguoiDungDto nguoidung)
        {
            return _nguoiDungRepo.Update(_mapper.Map<NguoiDung>(nguoidung));
        }

    }
}
