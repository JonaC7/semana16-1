using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace semana16_1.Controllers
{
    public class DatosPersonalesController : Controller
    {
        public IActionResult Index(string name, int edad, string celular, string correo)
        {
            ViewData["name"] = "Nombre: " + name;
            ViewData["edad"] = "Edad: " + edad;
            ViewData["celular"] = "Telefono: " + celular;
            ViewData["correo"] = "Correo Electronico: " + correo;
            return View();
        }
    }
}
//ViewData["edad"] = "Hola " + edad;
//ViewData["correo"] = "Hola " + correo;
//ViewData["telefono"] = "Hola " + telefono;