namespace ArtMuseum1
{
    public class Exhibits
    {
        public int id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public Author author { get; set; }
        public Category category { get; set; } 
    }
}