﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Application.Dtos
{
    public class PagingResquestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
