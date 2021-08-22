using Henry_Inc.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.ViewModels.Catalogs.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectedItem> Categories { get; set; } = new List<SelectedItem>();
    }
}
