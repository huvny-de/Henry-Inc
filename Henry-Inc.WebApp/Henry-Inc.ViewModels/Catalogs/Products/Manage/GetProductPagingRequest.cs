using Henry_Inc.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.ViewModels.Catalogs.Products.Manage
{
    public class GetProductPagingRequest : PagingResquestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
