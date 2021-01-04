using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhaozNet.CV.Integration.Repository.Interface
{
    public interface IBlogRssRepository
    {
        Task<List<string>> GetItems(int shortDescriptionLength = 250);
    }
}
