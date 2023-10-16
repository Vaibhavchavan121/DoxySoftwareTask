using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using VaibhavApp.Models;

namespace VaibhavApp.Controllers
{
    public class UserController : Controller
    {
        AppDbContext _db;

        public UserController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var user = _db.Users.ToList();
            return View(user);
        }
        public IActionResult Create()
        {

            var viewModel = new UserVM
            {
                users =new User(),
                Country = _db.Countries.ToList().Select(a => new SelectListItem
                {
                    Text = a.Name,
                    Value = a.Name.ToString(),
                }),

               

            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserVM Model)
        {
            if (Model.users.Id==0)
            {
                await _db.Users.AddAsync(Model.users);
                await _db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction("Index");
            }
            return View(Model);
        }

        public IActionResult Edit(int id)
        {
            var model=_db.Users.Find(id);
           

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(User Model)
        {
            if (ModelState.Count>0)
            {
                 _db.Users.Update(Model);
                await _db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction("Index");
            }
            return View(Model);
        }
        
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.Count > 0)
            {var model=_db.Users.Find(id);
                _db.Users.Remove(model);
                await _db.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction("Index");
            }
            return View();
        }






        [HttpGet]
        public JsonResult GetStatesByCountry(string countryname)
        {
            var states = _db.States.Where(s => s.Country.Name == countryname)
                .Select(s => new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Id.ToString()
                })
                .ToList();

            return Json(states);
        }
    }
}
