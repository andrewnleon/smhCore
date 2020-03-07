using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class WebBlogEntryCat
    {
        public int BlogEntryCatId { get; set; }
        public string BlogEntryCatPath { get; set; }
        public string BlogEntryCatTitle { get; set; }
        public string BlogEntryCatSort { get; set; }
        public string BlogEntryCatActive { get; set; }
    }
}
