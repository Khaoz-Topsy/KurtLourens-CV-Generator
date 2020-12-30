using System.IO;
using System.Threading.Tasks;
using KhaozNet.CV.Web.Pages;
using RazorLight;

namespace KhaozNet.CV.ConsoleApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string contentDirectory = args[0];
            string outputPath = args[1];

            WebHostEnvironment appEnvironment = new WebHostEnvironment
            {
                ContentRootPath = contentDirectory
            };

            RazorLightEngine engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(Path.Combine(contentDirectory, "Pages"))
                .UseMemoryCachingProvider()
                .Build();

            await ViewToFileHelper.Generate(engine, "Index.cshtml", new IndexModel(appEnvironment), outputPath, "index.html");
        }
    }
}
