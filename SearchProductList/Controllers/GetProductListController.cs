using Microsoft.AspNetCore.Mvc;
using SearchProductList.Repository.Interface;

namespace SearchProductList.Controllers
{
    public class GetProductListController : Controller
    {
        private readonly IGetProductListRepository repository;
        public GetProductListController(IGetProductListRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> PostProductList()
        {
            return Json(await repository.GetProductList());
        }
    }
}
