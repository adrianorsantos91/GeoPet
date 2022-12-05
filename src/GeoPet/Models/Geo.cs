namespace GeoPet.Models
{
    public class GeoPet
    {
        [Key]
        public int GeoId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [ForeignKey("PetId")]
        public int PetId { get; set; }
        public DateTime Created { get; set; }
    }
}