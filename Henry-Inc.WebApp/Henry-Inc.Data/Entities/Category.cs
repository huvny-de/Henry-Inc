using Henry_Inc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.Data.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
    }
}
