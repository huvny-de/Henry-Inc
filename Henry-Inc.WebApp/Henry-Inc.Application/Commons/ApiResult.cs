using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Application.Commons
{
   public class ApiResult<T>
    {

        public bool IsSucceeded { get; set; }
        public string  Message { get; set; }
        public T ResultObj { get; set; }

    }
}
