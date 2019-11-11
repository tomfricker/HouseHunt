namespace HouseHunt.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string URL { get; set; }
        
        public int HouseId { get; set; }
        public House House { get; set; }
    }
}