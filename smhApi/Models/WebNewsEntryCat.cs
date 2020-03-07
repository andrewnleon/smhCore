using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class WebNewsEntryCat
    {
        public int NewsEntryCatId { get; set; }
        public string NewsEntryCatPath { get; set; }
        public string NewsEntryCatTitle { get; set; }
        public string NewsEntryCatActive { get; set; }
    }
}
