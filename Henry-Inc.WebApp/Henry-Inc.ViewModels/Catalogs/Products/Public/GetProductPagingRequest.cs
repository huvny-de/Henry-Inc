using Henry_Inc.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.ViewModels.Catalogs.Products.Public
{
    public class GetProductPagingRequest : PagingResquestBase
    {
        public int? CategoryId { get; set; }

    }
}
