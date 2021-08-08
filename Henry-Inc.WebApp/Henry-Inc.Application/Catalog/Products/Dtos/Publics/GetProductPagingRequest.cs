using Henry_Inc.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Application.Catalog.Products.Dtos.Publics
{
    public class GetProductPagingRequest : PagingResquestBase
    {
        public int? CategoryId { get; set; }

    }
}
