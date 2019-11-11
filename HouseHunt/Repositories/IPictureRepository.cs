using System.Collections.Generic;

namespace HouseHunt.Models
{
    public interface IPictureRepository
    {
        IEnumerable<Picture> GetAllPicturesForHouse(int houseId);
    }
}
