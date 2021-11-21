using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Netmo.Controllers
{
    public class HelloWorldController : Controller
    {
        //action
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}