using Microsoft.AspNetCore.Mvc;

namespace UrlHelperFailure.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }

        public ActionResult TestQuery(int test)
        {
            return View();
        }
    }
}
