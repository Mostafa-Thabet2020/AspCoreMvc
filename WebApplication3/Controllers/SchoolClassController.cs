using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.IReposetories;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SchoolClassController : Controller
    {
        private readonly ISchoolClassRepository schoolClassRepository;
        private readonly ILogger<SchoolClassController> logger;

        public SchoolClassController(ISchoolClassRepository _schoolClassRepository, ILogger<SchoolClassController> _logger)
        {
            schoolClassRepository = _schoolClassRepository;
            logger = _logger;
        }

        public async Task<IActionResult> Create()
        {
            try
            {
                logger.LogInformation("Create page is success");
                return View();
            }
            catch (Exception ex)
            {
                logger.LogError("Error during create page", ex);
                throw;
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SchoolClass schoolClass)
        {
            if (ModelState.IsValid)
            {
                logger.LogInformation("Model state is valid");
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
            else
            {
                logger.LogWarning("Model state not valid");
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
