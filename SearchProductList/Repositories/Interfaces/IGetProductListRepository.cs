using SearchProductList.Models;

namespace SearchProductList.Repository.Interface
{
    public interface IGetProductListRepository
    {
        Task<ProductListModel> GetProductList();
    }
}
