using Henry_Inc.ViewModels.Catalogs.Categories;
using Henry_Inc.ViewModels.Catalogs.ProductImages;
using Henry_Inc.ViewModels.Catalogs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henry_Inc.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryViewModel Category { get; set; }
        public ProductViewModel Product { get; set; }
        public List<ProductViewModel> RelatedProducts { get; set; }
        public List<ProductImageViewModel> ProductImages { get; set; }

    }
}
