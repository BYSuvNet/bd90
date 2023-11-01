namespace BD90.Model;

class Book : CatalogueItem
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PageCount { get; set; }

    public override bool Contains(string searchString)
    {
        return Title.Contains(searchString, StringComparison.InvariantCultureIgnoreCase) ||
               Author.Contains(searchString, StringComparison.InvariantCultureIgnoreCase) ||
               ISBN.Contains(searchString, StringComparison.InvariantCultureIgnoreCase);
    }

    public override string ToString()
    {
        return $"{Id}: Book: {Title} by {Author} released {ReleaseDate.ToShortDateString()} with ISBN {ISBN} and {PageCount} pages";
    }
}