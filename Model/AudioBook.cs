namespace BD90.Model;

class AudioBook : CatalogItem
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int LengthInMinutes { get; set; }
}