using WebApplication1.Models;
namespace WebApplication1.Models
{
    public class Products
    {
        public Products(int id, string img, string name, bool customerView, Category category)
        {
            Img = img;
            Id = id;
            Name = name;
            CustomerView = customerView;
            Categories = category;
        }
        
        public Products(int id, string img, string name)
        {
            Img = img;
            Id = id;
            Name = name;
        }
        public int? Id { get; set; }
        public string Img { get; set; }
        public string? Name { get; set; }
        bool CustomerView { get; set; }
        public Category? Categories { get; set; }
    }
}
