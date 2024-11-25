using Microsoft.AspNetCore.Mvc;

namespace Expenses_Analyzer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
