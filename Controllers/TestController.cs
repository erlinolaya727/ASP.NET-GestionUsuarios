using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers{
    
    public class TestController : Controller{

        public IActionResult Index(){
            return View();
        }

        public IActionResult Saludo(string nombre="Erlin", int edad=32){
            ViewData["nombre"]=$"Hola {nombre}";
            ViewData["edad"]=edad;
            return View();
        }


    }
}

