using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.IReposetories;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SchoolClassController : Controller
    {
        private readonly ISchoolClassRepository schoolClassRepository;

        public SchoolClassController(ISchoolClassRepository _schoolClassRepository)
        {
            schoolClassRepository = _schoolClassRepository;
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SchoolClass schoolClass)
        {
            if (ModelState.IsValid)
            {
                bool result = await schoolClassRepository.Add(schoolClass);
                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(schoolClassRepository.Get());
        }
    }
}
