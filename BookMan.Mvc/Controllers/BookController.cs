using BookMan.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookMan.Mvc.Controllers
{
    public class BookController : Controller
    {
        private readonly Service _service;
        public BookController(Service service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.Get());
        }

        public IActionResult Details(int id)
        {
            var b = _service.Get(id);
            if (b == null) return NotFound();
            else return View(b);
        }
       
    }
}
