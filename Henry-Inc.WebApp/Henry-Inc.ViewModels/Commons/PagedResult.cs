using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.ViewModels.Commons
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; }
    }
}
