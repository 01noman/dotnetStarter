using Microsoft.AspNetCore.Mvc;

namespace WebAppStartar.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/admindashboard")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}