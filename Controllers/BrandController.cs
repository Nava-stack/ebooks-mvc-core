using EBooksPvtLtd.Data;
using EBooksPvtLtd.Models;
using Microsoft.AspNetCore.Mvc;

namespace EBooksPvtLtd.Controllers
{
    public class BrandController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public BrandController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Brand> brands = _dbContext.Brand.ToList();
            return View(brands);
        }
    }
}
