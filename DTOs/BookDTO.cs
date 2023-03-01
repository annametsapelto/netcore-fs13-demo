namespace NETCoreDemo.DTOs;

using NETCoreDemo.Models;

public class BookDTO : BaseDTO<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PageCount { get; set; }

    public override void UpdateModel(Book model)
    {
        throw new NotImplementedException();
    }
}
 
