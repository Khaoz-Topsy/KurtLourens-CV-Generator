using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using KhaozNet.CV.Domain;
using KhaozNet.CV.Domain.Entity.Blog;
using KhaozNet.CV.Domain.Entity.CvData;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using KhaozNet.CV.Integration.Repository;

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

        public async Task OnGet()
        {
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            string cvDataJson = await System.IO.File.ReadAllTextAsync(contentRootPath + "/cv.json");
            CvData = JsonConvert.DeserializeObject<CvJsonData>(cvDataJson);

            BlogRssRepository blogRepo = new BlogRssRepository();
            CvData.BlogPosts = (await blogRepo.GetItems()).Take(4).ToList();
        }
    }
}
