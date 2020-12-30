using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhaozNet.CV.Domain.Entity;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace KhaozNet.CV.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CvJsonData CvData { get; set; }

        public IndexModel(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public void OnGet()
        {
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            string cvDataJson = System.IO.File.ReadAllText(contentRootPath + "/cv.json");
            CvData = JsonConvert.DeserializeObject<CvJsonData>(cvDataJson);
        }
    }
}
