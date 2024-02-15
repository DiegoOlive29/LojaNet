using Microsoft.AspNetCore.Mvc;
using LojaNet.Models;
namespace LojaNet.Ui.Web.Controllers
{
    public class ClienteController : Controller
    {

        public ActionResult Incluir()
        {
            var cli = new Cliente();



            return View(cli);

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
