using Henry_Inc.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.ViewModels.Catalogs.Products
{
    public class GetPublicProductPagingRequest : PagingResquestBase
    {
        public string languageId { get; set; }
        public int? CategoryId { get; set; }

    }
}
