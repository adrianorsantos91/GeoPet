namespace GeoPet.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }
        public string Porte { get; set; }
        public string Raca { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}