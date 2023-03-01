namespace NETCoreDemo.Services;

using NETCoreDemo.DTOs;
using NETCoreDemo.Models;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class FakeBookService : IBookService
{
    public Book? Create(BookDTO request)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Book? Get(int id)
    {
        throw new NotImplementedException();
    }

    public ICollection<Book> GetAll()
    {
        throw new NotImplementedException();
    }

    public Book? Update(int id, BookDTO request)
    {
        throw new NotImplementedException();
    }
}