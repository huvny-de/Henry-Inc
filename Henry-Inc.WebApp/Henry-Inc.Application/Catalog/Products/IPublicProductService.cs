using Henry_Inc.Application.Catalog.Products.Dtos;
using Henry_Inc.Application.Catalog.Products.Dtos.Publics;
using Henry_Inc.Application.Dtos;
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
