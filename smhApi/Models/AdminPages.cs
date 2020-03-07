using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class AdminPages
    {
        public int PageId { get; set; }
        public string PageTitle { get; set; }
        public string PagePath { get; set; }
        public string PageTemplate { get; set; }
        public string PageRole { get; set; }
        public bool? PageActive { get; set; }
    }
}
