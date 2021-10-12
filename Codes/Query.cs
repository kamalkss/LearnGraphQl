using Demo.Models;

namespace Demo.Codes
{
    public class Query
    {
        public Book GetBook() => new Book 
        {
            Title = "C# in Depth",
            Author = new Author {  Name = "John"}
        };
    }
}
