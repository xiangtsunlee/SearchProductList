using System.Text;
using SearchProductList.Tool;
using SearchProductList.Models;
using System.Security.Cryptography;
using SearchProductList.Repository.Interface;

namespace SearchProductList.Repository
{
    public class GetTokenRepository : IGetTokenRepository
    {
        public async Task<string> GetToken()
        {
            string guid = Guid.NewGuid().ToString().Replace("-", "").ToLowerInvariant();
            string checkNum = (BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(guid + Setting.ApiKey + Setting.ApiSecret + DateTime.UtcNow.ToString("HHmmss")))).Replace("-", null) + guid);
            
            HttpClient httpClient = new();
            TokenRequest tokenRequest = new()
            {
                ApiKey = Setting.ApiKey,
                ApiSecret = Setting.ApiSecret,
                Checksum = checkNum,
            };
            HttpContent content = new StringContent(System.Text.Json.JsonSerializer.Serialize(tokenRequest), Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(Setting.AuthToken, content);
            string ConverToString = await httpResponseMessage.Content.ReadAsStringAsync();
            TokenModel? token = System.Text.Json.JsonSerializer.Deserialize<TokenModel>(ConverToString);
            return token.Data.AccessToken;
        }
    }
}
