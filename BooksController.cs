using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStoreSDK.Models;

namespace BookStoreSDK.Controllers;

public class BooksController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Details()
    {
        Book b1=new Book()
        {
            ID=1,
            Title=".NET 6.0",
            Genre="Programming",
            Authors=new List<string>{"Raja","Rani"},
            Price=250,
            PublishDate=new System.DateTime(2022,03,10)
        };
        return View(b1);
    }
}