namespace Maxim_Cazacu_Laborator2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int? GenreID { get; set; }
        public Genre? Genre { get; set; }
        public int? AuthorID { get; set; } // Foreign Key
        public Author? Author { get; set; } // Navigation Property
        public ICollection<Order>? Orders { get; set; }
    }
}
