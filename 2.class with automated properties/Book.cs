

namespace _2.class_with_automated_properties
{
    internal class Book
    {
        public string Titile {  get; set; }
        public string Author { get; set; }

        public Book(string titile, string author)
        {
            Titile = titile;
            Author = author;
        }

        public void BookDetails() {
            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {Titile}");
            Console.WriteLine($"Author: {Author}");
        }
    }
}
