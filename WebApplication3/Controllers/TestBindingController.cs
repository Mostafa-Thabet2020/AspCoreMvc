using Microsoft.AspNetCore.Mvc;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class TestBindingController : Controller
    {
        StudentVM studentVM;
        List<StudentVM> studentVMs;
        public TestBindingController()//constractor
        {
            studentVM = new StudentVM() { FirstName = "Hussen", LastName = "El shater"
                //,contant=new Contant { Address = "maadi", Mobile = "015155" }
            };
            studentVMs = new List<StudentVM>() {
                new StudentVM() { FirstName="ali",LastName="Mohamed"},
                new StudentVM() { FirstName="Samy",LastName="Hussin"},
                new StudentVM() { FirstName="Sobhy",LastName="Samir"},
            };
        }
        public IActionResult ViewDataBinding()
        {
            ViewData["Student"] = $"{studentVM.FirstName} {studentVM.LastName}";//static
            return View();
        }
        public IActionResult ViewBagBinding()
        {
            ViewBag.Student = studentVM;//Dynamic
            return View();
        }
        public IActionResult TempDateBinding()
        {
            TempData["Student"] = studentVMs;// temp , can reuse in another controller and another actions
            return View();
        }
        public IActionResult ViewBinding()
        {
            //ViewBag.Content = new Contant() { Address = "Maadi", Mobile = "0115154" };
            return View(studentVM);
        }
    }
}
