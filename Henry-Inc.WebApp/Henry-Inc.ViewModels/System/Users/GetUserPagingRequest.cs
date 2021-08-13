using Henry_Inc.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingResquestBase
    {
        public string Keyword { get; set; }
    }
}
