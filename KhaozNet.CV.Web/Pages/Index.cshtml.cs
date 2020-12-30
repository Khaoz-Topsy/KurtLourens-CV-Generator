using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using KhaozNet.CV.Domain;
using KhaozNet.CV.Domain.Entity;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace KhaozNet.CV.Web.Pages
{
    public class IndexModel : PageModel, IRazorModel
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CvJsonData CvData { get; set; }

        public IndexModel(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public Task OnGet()
        {
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            string cvDataJson = System.IO.File.ReadAllText(contentRootPath + "/cv.json");
            CvData = JsonConvert.DeserializeObject<CvJsonData>(cvDataJson);

            return Task.CompletedTask;
        }
    }
}
