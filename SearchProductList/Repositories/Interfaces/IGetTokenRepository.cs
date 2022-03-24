using SearchProductList.Models;
using System.Net.Http;

namespace SearchProductList.Repository.Interface
{
    public interface IGetTokenRepository
    {
        Task<string> GetToken();
    }
}
