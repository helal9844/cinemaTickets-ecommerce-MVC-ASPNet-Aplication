using cinemaTickets.Data;
using cinemaTickets.Models;
using cinemaTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace cinemaTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePic,FirstName,LastName,Age,BIO")] Actor actor)
        {
            if (!ModelState.IsValid)
                return View(actor); 
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null)
                return View("Empty");
            return View(actor);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null)
                return View("Empty");
            return View(actor);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePic,FirstName,LastName,Age,BIO")] Actor actor)
        {
            if (!ModelState.IsValid)
                return View(actor);
            await _service.EditAsync(id ,actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null)
                return View("Empty");
            return View(actor);
        }
        [HttpPost,ActionName("Delete")] 
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null)
                return View("Empty");
            await _service.DeleteAsync(id);

            
            return RedirectToAction(nameof(Index));
        }
    }
}
