﻿using Henry_Inc.Data.Enums;

namespace Henry_Inc.ViewModels.Utilities.Slides
{
    public class SlideViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Url { set; get; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public Status Status { set; get; }
    }

}
