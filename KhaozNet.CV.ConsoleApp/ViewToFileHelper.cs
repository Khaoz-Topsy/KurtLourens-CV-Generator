using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using KhaozNet.CV.Domain;
using RazorLight;

namespace KhaozNet.CV.ConsoleApp
{
    public static class ViewToFileHelper
    {
        public static async Task Generate<T>(IRazorLightEngine engine, string cshtml, T model, string outputPath, params string[] outputNames) where T : IRazorModel
        {
            await model.OnGet();
            string homePageHtml = await engine.CompileRenderAsync(cshtml, model);

            foreach (string tempOutputName in outputNames)
            {
                string outputName = tempOutputName.Replace('/', Path.DirectorySeparatorChar);
                string homePagePath = Path.Combine(outputPath, outputName);

                int directorySeparatorIndex = homePagePath.LastIndexOf(Path.DirectorySeparatorChar);
                if (directorySeparatorIndex > 0)
                {
                    string dir = homePagePath.Remove(directorySeparatorIndex, homePagePath.Length - directorySeparatorIndex);
                    if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                }

                homePageHtml = Regex.Replace(homePageHtml, @"\>\s+\<", "><");

                if (File.Exists(homePagePath)) File.Delete(homePagePath);
                await File.WriteAllTextAsync(homePagePath, homePageHtml);
            }
        }
    }
}
