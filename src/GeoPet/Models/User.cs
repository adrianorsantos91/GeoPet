namespace GeoPet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string keys { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public DateTime created { get; set; }
    }
}