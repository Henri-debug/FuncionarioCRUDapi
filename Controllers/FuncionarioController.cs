using Microsoft.AspNetCore.Mvc;

namespace FuncionariosCRUD.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
