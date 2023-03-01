namespace NETCoreDemo.Services;

using NETCoreDemo.Models;
using NETCoreDemo.DTOs;

public interface IBookService : ICrudService<Book, BookDTO>
{
}