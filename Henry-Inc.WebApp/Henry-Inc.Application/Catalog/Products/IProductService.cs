
using Henry_Inc.Application.Commons;
using Henry_Inc.ViewModels.Catalogs.Orders;
using Henry_Inc.ViewModels.Catalogs.ProductImages;
using Henry_Inc.ViewModels.Catalogs.Products;
using Henry_Inc.ViewModels.Commons;
using Henry_Inc.ViewModels.Sales;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Henry_Inc.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<List<ProductImageViewModel>> GetListImages(int productId);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string Id, GetPublicProductPagingRequest request);
        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
        Task<List<ProductViewModel>> GetFeaturedProducts(string languageId, int take);
        Task<List<ProductViewModel>> GetLatestProducts(string languageId, int take);
        public Task<int> CreateOrder(string userName, CheckoutRequest request);
    }
}
