namespace myfirstapi.Models
{
    public class Character
    {
        public int HitPoints { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public CharUser CharUser { get; set;}
    }
}