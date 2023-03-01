namespace NETCoreDemo.Controllers;

using NETCoreDemo.Services;
using NETCoreDemo.Models;
using NETCoreDemo.DTOs;
using Microsoft.AspNetCore.Mvc;

public class BookController : CrudController<Book, BookDTO>
{
    private readonly IBookService _service;

    public BookController(IBookService service) : base(service)
    {
        
    }
}