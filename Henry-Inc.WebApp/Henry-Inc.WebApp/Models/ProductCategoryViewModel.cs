using Henry_Inc.ViewModels.Catalogs.Categories;
using Henry_Inc.ViewModels.Catalogs.Products;
using Henry_Inc.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henry_Inc.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }
        public PagedResult<ProductViewModel> Products { get; set; }
    }
}
