namespace BookStoreSDK.Models;

public class Book
{
    public int ID {get; set;}
    public string Title {get; set;}
    public string Genre {get; set;}
    public List<string> Authors {get; set;}
    public decimal Price {get; set;}
    public DateTime PublishDate {get; set;}
}