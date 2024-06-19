using efCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace efCoreApp.Controllers {
    public class OgrenciController: Controller {
        private readonly DataContext _context;

        public OgrenciController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            return View(await _context.Ogrenciler.ToListAsync());
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ogrenci model) {
            _context.Ogrenciler.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}