using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class WebOfficeLocations
    {
        public int LocationId { get; set; }
        public string LocationTitle { get; set; }
        public string LocationHref { get; set; }
        public string LocationAddress { get; set; }
        public string LocationPhoneNumber { get; set; }
        public string LocationMap { get; set; }
    }
}
