using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace First_demo_model_view_controller.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

    }
}
