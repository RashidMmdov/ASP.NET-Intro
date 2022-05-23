using Microsoft.AspNetCore.Mvc;

namespace First_task.Controllers
{
    public class HomeController : Controller
    {
        //public ContentResult Index()
        //{
        //    return Content("Hello World!");
        //}
        //public ViewResult Index()
        //{
        //    ViewResult view = new ViewResult
        //    {
        //        ViewName = "Index"
        //    };
        //    return view;
        //}
        //public ViewResult About()
        //{
        //    return new ViewResult { ViewName = "About" };
        //}
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}
