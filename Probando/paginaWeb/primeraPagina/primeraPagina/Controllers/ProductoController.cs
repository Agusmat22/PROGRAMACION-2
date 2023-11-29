using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using primeraPagina.Models;

namespace primeraPagina.Controllers
{
    public class ProductoController : Controller
    {
        private readonly PixContext pixContext;

        public ProductoController(PixContext pixContext)
        {
            this.pixContext = pixContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await pixContext.Productos.ToListAsync());
        }
    }
}
