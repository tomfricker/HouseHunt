using System;
using System.Collections.Generic;

namespace HouseHunt.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ShortDescription { get; set; }
        public int Price { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public DateTime WhenSeen { get; set; }
        public bool Sold { get; set; }
        public string RightMoveUrl { get; set; }
        public string FloorPlan { get; set; }
        public bool Favourite { get; set; }

        public List<Picture> Pictures { get; set; }
    }
}
