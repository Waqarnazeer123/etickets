using etickets.Data.Services;
using etickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace etickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService _service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAllAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        { 
          return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("fullname,ProfilePictureURL,Biography")] (Actor actor)

        {
            if (!ModelState.IsValid)
            {
                return View(Actor);
            }
            _service.Add(actor);
            return RedirectToAction (nameof(Index));
        }
        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
         var actorDetails = await_service.GetByIdAsync(id);
            if (actorDetails == null) return View("Notfound");
            return View(actorDetails);

        }

         
        //Get: Actors/Edit/1
        public async Task <IActionResult> Edit (int id)

        {
            var actorDetails = await_service.GetByIdAsync(id);
            if (actorDetails == null) return View("Notfound");
            return View(actorDetails);

            
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("fullname,ProfilePictureURL,Biography")] (Actor actor)

        {
            if (!ModelState.IsValid)
            {
                return View(Actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));

        }

        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)

        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Notfound");
            return View(actorDetails);


        }
        [HttpPost, ActionName ("Delete")]
        public async Task<IActionResult> Deleteconfirmed (int id, [Bind("fullname,ProfilePictureURL,Biography")] (Actor actor)

        {
            var actordetails = await _service.GetByIdasync(id);
            if (actorDetails == null) return View("Notfound");

            await _service.DeleteAsync(id);
           
            return RedirectToAction(nameof(Index));

        }
}
