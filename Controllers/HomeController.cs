using Microsoft.AspNetCore.Mvc;
using CampaniasCRUD_NET9.Models;
using System.Diagnostics;

namespace CampaniasCRUD_NET9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
