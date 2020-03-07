using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class WebMetroAreas
    {
        public int MetroAreaId { get; set; }
        public string MetroAreaTitle { get; set; }
        public int? MetroAreaCode { get; set; }
        public string MetroAreaState { get; set; }
        public string MetroAreaPagePath { get; set; }
        public string MetroAreaSubTitle { get; set; }
        public string MetroAreaGreeting { get; set; }
        public string MetroAreaVideo { get; set; }
        public string MetroAreaTestimonial { get; set; }
        public string MetroAreaPhoneNumber { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string MetroPromoImgUrl { get; set; }
        public string MetroExspand { get; set; }
        public short? SalesManagerId { get; set; }
        public string MetaPageTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public bool? MetroAreaActive { get; set; }
    }
}
