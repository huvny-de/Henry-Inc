using Henry_Inc.Application.Commons;
using Henry_Inc.ViewModels.Catalogs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henri_Inc.ApiIntergration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll(string languageId);
        Task<CategoryViewModel> GetById(int id, string languageId);

    }
}
