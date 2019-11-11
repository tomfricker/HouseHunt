using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseHunt.Models
{
    public class PictureRepository : IPictureRepository
    {
        private readonly AppDbContext _appDbContext;

        public PictureRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Picture> GetAllPicturesForHouse(int houseId)
        {
            return _appDbContext.Pictures.Where(p => p.HouseId == houseId).ToList();
        }
    }
}
