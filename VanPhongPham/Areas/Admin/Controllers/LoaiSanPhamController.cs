using Microsoft.AspNetCore.Mvc;
using Model.Dto;
using Service.IService;

namespace VanPhongPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiSanPhamController : Controller
    {
        private readonly ILoaiSanPhamService _loaiSanPhamService;
        private readonly ICloudinaryService _cloudinaryService;
        public LoaiSanPhamController(ILoaiSanPhamService loaiSanPhamService, ICloudinaryService cloudinaryService)
        {
            _loaiSanPhamService = loaiSanPhamService;
            _cloudinaryService = cloudinaryService;
        }
     
        public IActionResult Index()
        {
            return View(_loaiSanPhamService.Index());
        }
        [HttpPost]
        public IActionResult Create(LoaiSanPhamDto model)
        {
            if (ModelState.IsValid)
            {
                model.LoaiSanPhamId = 0;
                _loaiSanPhamService.Create(model);
                return RedirectToAction("Index", "LoaiSanPham","Admin");
            }
            return View(model);
        }
    }
}
