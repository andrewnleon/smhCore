using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class WebPages
    {
        public int PageId { get; set; }
        public string PagePath { get; set; }
        public string PageTemplate { get; set; }
        public string PageCategory { get; set; }
        public short PageParent { get; set; }
        public string PagePriority { get; set; }
        public bool? PageActive { get; set; }
    }
}
