namespace SectionListMvvmCross.Models
{
    public class Book
    {
        public Book(string name, string author)
        {
            Author = author;
            Name = name;
        }

        public string Author { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} by {Author}";
        }
    }
}
