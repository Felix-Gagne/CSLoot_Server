namespace CSLoot.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Items Items { get; set; }
    }
}
