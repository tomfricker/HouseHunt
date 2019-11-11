using HouseHunt.Models;
using System.Collections.Generic;

namespace HouseHunt.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<House> Houses { get; set; }
    }
}
