using System.Collections.Generic;

namespace SLH.Feature.Location.Models
{
    public class LocationMapViewModel
    {
        public IEnumerable<PoiItem> PoiItems { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public string ImageUrl { get; set; }
    }
}