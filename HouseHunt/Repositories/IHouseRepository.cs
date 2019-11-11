using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseHunt.Migrations;

namespace HouseHunt.Models
{
    public interface IHouseRepository
    {
        IEnumerable<House> GetAllHouses();
        House GetHouseById(int houseId);
        void AddHouse(House house);
        void AddPicture(Picture picture);
        void Delete(int houseId);
        House EditHouse(House house);
        House GetFavourite();
    }
}
