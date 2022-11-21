using Adibidea.Models;
using Microsoft.AspNetCore.Mvc;

namespace Adibidea.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            Kontaktua kontaktua = new Kontaktua("13456765", "Raul", "Parra");
            kontaktua.Emaila = "parra.raul@uni.eus";
            return View(kontaktua);
        }

    }
}
