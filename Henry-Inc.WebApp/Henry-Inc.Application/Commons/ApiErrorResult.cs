using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Application.Commons
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationsErrors { get; set; }
        public ApiErrorResult()
        {
        }
        public ApiErrorResult(string message)
        {
            IsSucceeded = false;
            Message = message;
        }

        public ApiErrorResult(string[] validationsErrors)
        {
            IsSucceeded = false;
            ValidationsErrors = validationsErrors;
        }
    }
}
