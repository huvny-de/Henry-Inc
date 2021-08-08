using Henry_Inc.Application.Catalog.Products.Dtos;
using Henry_Inc.Application.Catalog.Products.Dtos.Manages;
using Henry_Inc.Application.Dtos;
using System.Threading.Tasks;

namespace Henry_Inc.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<int> Delete(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

    }
}
