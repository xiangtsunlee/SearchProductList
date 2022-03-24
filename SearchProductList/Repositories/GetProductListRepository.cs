using Microsoft.Extensions.PlatformAbstractions;
using SearchProductList.Models;
using SearchProductList.Repository.Interface;
using SearchProductList.Tool;
using System.Text.Json;

namespace SearchProductList.Repository
{
    public class GetProductListRepository : IGetProductListRepository
    {
        public Info info = new();
        public MongoModel model = new();
        private readonly Service service;
        private readonly IGetTokenRepository repo;

        public GetProductListRepository(IGetTokenRepository repo,Service service)
        {
            this.repo = repo;
            this.service = service;
        }
        public async Task<ProductListModel> GetProductList()
        {
            HttpClient client = new();
            client.BaseAddress = new Uri(Setting.RoadUrl);
            client.DefaultRequestHeaders.Add("Authorization", await repo.GetToken());
            HttpResponseMessage httpResponseMessage = await client.GetAsync(Setting.ActionData + Setting.SourceJsonString);
            ProductListModel? result = JsonSerializer.Deserialize<ProductListModel>(await httpResponseMessage.Content.ReadAsStringAsync());

            //取用專案名稱作為ApplicationName
            model.ApplicationName = PlatformServices.Default.Application.ApplicationName;
            model.ActionData = Setting.ActionData;
            model.SourceJsonString = Setting.SourceJsonString;
            model.ReturnJsonString = result;
            info.Token = await repo.GetToken();
            info.HttpCode = (int)httpResponseMessage.StatusCode;
            info.MethodType = httpResponseMessage.RequestMessage.Method.ToString();
            model.Info = info;
            await service.CreateAsync(model);

            return result;
        }
    }
}
