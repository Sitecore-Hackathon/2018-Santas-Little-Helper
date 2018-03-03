using System;

namespace SLH.Feature.Location.Models
{
    public class PoiItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string IconClass { get; set; }
        public decimal Top { get; set; }
        public decimal Left { get; set; }
    }
}