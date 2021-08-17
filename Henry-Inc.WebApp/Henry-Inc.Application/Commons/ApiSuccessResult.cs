using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Application.Commons
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObj)
        {
            IsSucceeded = true;
            ResultObj = resultObj;
        }
        public ApiSuccessResult()
        {
            IsSucceeded = true;
        }
    }
}
