using Henry_Inc.ViewModels.Catalogs.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Henry_Inc.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll(string languageId);
        Task<CategoryViewModel> GetById(string languageId, int id);

    }
}
