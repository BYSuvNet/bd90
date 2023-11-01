namespace BD90.Model;

class AudioBook : CatalogueItem
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int LengthInMinutes { get; set; }

    public override bool Contains(string value)
    {
        return Title.Contains(value, StringComparison.InvariantCultureIgnoreCase) ||
               Author.Contains(value, StringComparison.InvariantCultureIgnoreCase) ||
               ISBN.Contains(value, StringComparison.InvariantCultureIgnoreCase);
    }

    public override string ToString()
    {
        return $"{Id}: Audiobook: {Title} by {Author} released {ReleaseDate.ToShortDateString()} with ISBN {ISBN} and being {LengthInMinutes} minutes long.";
    }
}