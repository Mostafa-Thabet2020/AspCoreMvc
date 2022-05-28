using Microsoft.AspNetCore.Mvc;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class TaxiController : Controller
    {
        public IActionResult TaxiIndex()
        {
            List<TaxiResult> taxiResults = new List<TaxiResult>()
            {
                new TaxiResult(){ TaxiName="Uber",Cost=10},
                new TaxiResult(){ TaxiName="Yellow taxi",Cost=20},
                new TaxiResult(){ TaxiName="Indrive",Cost=15},
            };
            return View(taxiResults);
        }
    }
}
