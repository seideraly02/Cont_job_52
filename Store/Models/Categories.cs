namespace Store.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ValidUntil { get; set; }
        public Store Store { get; set; }
    }
}