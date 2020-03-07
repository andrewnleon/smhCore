using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class WebNewsEntry
    {
        public int NewsEntryId { get; set; }
        public string NewsEntryTitle { get; set; }
        public string NewsEntryPagePath { get; set; }
        public bool? NewsEntryFeatured { get; set; }
        public int? NewsEntryCat { get; set; }
        public string NewsEntrySubTitle { get; set; }
        public string NewsEntryExcerpt { get; set; }
        public string NewsEntryBody { get; set; }
        public string NewsEntryAuthor { get; set; }
        public string NewsEntryPosted { get; set; }
        public string NewsEntryTag { get; set; }
        public DateTime? NewsEntryDate { get; set; }
        public string NewsEntryNoFollow { get; set; }
        public string NewsEntryPageTitle { get; set; }
        public string NewsEntryPageKeywords { get; set; }
        public string NewsEntryPageDescription { get; set; }
        public bool? NewsEntryActive { get; set; }
    }
}
