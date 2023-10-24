namespace BD90.Model;

class Magazine : CatalogItem
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Issue { get; set; }
}