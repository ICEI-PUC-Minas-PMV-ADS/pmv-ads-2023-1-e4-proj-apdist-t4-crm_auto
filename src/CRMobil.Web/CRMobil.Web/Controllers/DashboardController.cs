using Microsoft.AspNetCore.Mvc;

namespace CRMobil.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
