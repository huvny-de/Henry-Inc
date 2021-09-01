using Henry_Inc.Application.Commons;
using Henry_Inc.ViewModels.Catalogs.Orders;
using Henry_Inc.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Henri_Inc.ApiIntergration
{
    public interface IOrderApiClient
    {
        Task<bool> CreateOrder(string userName, CheckoutRequest request);
    }
}
