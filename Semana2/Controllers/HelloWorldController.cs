using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Semana2.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/ Reemplazar el método index:

        public string Index()
        {
            return "Esta es mi accion por defecto...";
        }

        //
        //GET: /HelloWorld/Welcome/ Agregar este método:

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, Bienvenido , Acabas de entrar: {numTimes} Vez");
        }
    }
}
