namespace WebApplication1.Models
{
    public class Category
    {
        public Category(string name)
        {
            Categories = new();
            Categories.Add(name);
        }

        public Category(string name0, string name1)
        {
            Categories = new();
            Categories.Add(name0);
            Categories.Add(name1);
        }

        public Category(string name0, string name1, string name2)
        {
            Categories = new();
            Categories.Add(name0);
            Categories.Add(name1);
            Categories.Add(name2);
        }

        public List<string>? Categories { get; set; }
    }
}
