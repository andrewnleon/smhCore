using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class WebBlogEntry
    {
        public int BlogEntryId { get; set; }
        public string BlogEntryPagePath { get; set; }
        public bool? BlogEntryFeatured { get; set; }
        public string BlogEntryTitle { get; set; }
        public string BlogEntrySubTitle { get; set; }
        public string BlogEntryExcerpt { get; set; }
        public string BlogEntryBody { get; set; }
        public string BlogEntryAuthor { get; set; }
        public string BlogEntryTag { get; set; }
        public DateTime? BlogEntryDate { get; set; }
        public short? BlogEntryCat { get; set; }
        public int? MetroAreaId { get; set; }
        public string ProjectGroupId { get; set; }
        public string ProductId { get; set; }
        public string BlogEntryHtml { get; set; }
        public string BlogEntryNoFollow { get; set; }
        public string BlogEntryPageTitle { get; set; }
        public string BlogEntryPageKeywords { get; set; }
        public string BlogEntryPageDescription { get; set; }
        public bool? BlogEntryActive { get; set; }
    }
}
