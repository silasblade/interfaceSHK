using Microsoft.AspNetCore.Mvc;
using QLHK.Core6.Models;

namespace QLHK.Controllers
{
    public class ListSHKController : Controller
    {
        private readonly AppHKDbContext _context;

        public ListSHKController(AppHKDbContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
           var ListNK = _context.NhanKhaus
                .Where(c => c.MaHoKhau == "HK004")
                .ToList();
            return View(ListNK);
        }
    }
}
