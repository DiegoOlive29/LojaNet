using Microsoft.AspNetCore.Mvc;

namespace LojaNet.Ui.Web.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
