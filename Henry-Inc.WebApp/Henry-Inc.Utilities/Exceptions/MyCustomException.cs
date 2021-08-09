using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Utilities.Exceptions
{
    public class MyCustomException : Exception
    {
        public MyCustomException() { }

        public MyCustomException(string message)
            : base(message) { }

        public MyCustomException(string message, Exception inner)
            : base(message, inner) { }
    }
}
