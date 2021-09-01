using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Utilities.Constants
{
    public class SystemConstant
    {
        public const string CartSession = "CartSession";
        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";

            public const string Token = "Token";

            public const string BaseAddress = "https://localhost:5002";
        }
        public class ProductSettings
        {
            public const int NumberOfFeaturedProducts = 4;
            public const int NumberOfLatestProducts = 6;

        }
        public class ProductConstants
        {
            public const string NA = "N/A";
        }

    }
}
