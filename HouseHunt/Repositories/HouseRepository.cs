using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseHunt.Models
{
    public class HouseRepository : IHouseRepository
    {
        private readonly AppDbContext _appDbContext;

        public HouseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<House> GetAllHouses()
        {
            return _appDbContext.Houses;
        }

        public House GetHouseById(int houseId)
        {
            return _appDbContext.Houses.FirstOrDefault(h => h.Id == houseId);
        }

        public void AddHouse(House house)
        {
            _appDbContext.Houses.Add(house);
            _appDbContext.SaveChanges();
        }

        public void AddPicture(Picture picture)
        {
            _appDbContext.Pictures.Add(picture);
            _appDbContext.SaveChanges();
        }

        public void Delete(int houseId)
        {
            var house = GetHouseById(houseId);
            _appDbContext.Houses.Remove(house);
            _appDbContext.SaveChanges();
        }

        public House EditHouse(House house)
        {
            _appDbContext.Houses.Update(house);
            _appDbContext.SaveChanges();
            return house;
        }

        public House GetFavourite()
        {
            return _appDbContext.Houses.FirstOrDefault(h => h.Favourite == true);
        }
    }
}
