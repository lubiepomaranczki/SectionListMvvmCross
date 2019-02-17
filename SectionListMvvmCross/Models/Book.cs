namespace SectionListMvvmCross.Models
{
    public class Book
    {
        public Book(string name, string author, string photoUrl)
        {
            Author = author;
            Name = name;
            PhotoUri = photoUrl;
        }

        public string Author { get; set; }

        public string Name { get; set; }
        public string PhotoUri { get; set; }

        public override string ToString()
        {
            return $"{Name} by {Author}";
        }
    }
}
