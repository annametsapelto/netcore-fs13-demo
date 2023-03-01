namespace NETCoreDemo.Models;

public class Book : BaseModel
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PageCount { get; set; }
}