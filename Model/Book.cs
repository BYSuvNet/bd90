namespace BD90.Model;

class Book : CatalogItem
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PageCount { get; set; }
}