namespace CSLoot.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Condition Conditions { get; set; }

        public enum Condition
        {
            FN,
            MW,
            FT,
            WW,
            BS
        }
    }
}
