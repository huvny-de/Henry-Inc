using Henry_Inc.ViewModels.Catalogs.Products;
using Henry_Inc.ViewModels.Catalogs.Products.Public;
using Henry_Inc.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Henry_Inc.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
