using System.Threading.Tasks;
using KhaozNet.CV.Web.Pages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace KhaozNet.CV.Web.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IWebHostEnvironment _appEnvironment;

        public HomeController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            IndexModel indexModel = new IndexModel(_appEnvironment);
            await indexModel.OnGet();

            return View("~/Pages/Index.cshtml", indexModel);
        }
    }
}