using Microsoft.AspNetCore.Mvc;

namespace Usuario.Controllers
{
    public class UsuarioControlller : Controller
    {
        public IActionResult Index(){
            return View();
        }

         public IActionResult Crear(){
            return null;
        }
    }
}

