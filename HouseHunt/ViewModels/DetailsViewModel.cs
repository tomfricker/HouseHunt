using System.Collections.Generic;
using HouseHunt.Models;

namespace HouseHunt.ViewModels
{
    public class DetailsViewModel
    {
        public House House { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}
