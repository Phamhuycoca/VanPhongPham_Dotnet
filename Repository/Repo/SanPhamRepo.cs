using Model.Context;
using Model.Model;
using Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public class SanPhamRepo : Repo<SanPham>, ISanPhamRepo
    {
        public SanPhamRepo(VanPhongPhamContext context) : base(context)
        {
        }
    }
}
