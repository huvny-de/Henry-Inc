using Henry_Inc.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Application.Catalog.Products.Dtos.Manages
{
    public class GetProductPagingRequest : PagingResquestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
