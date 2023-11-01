namespace BD90.Model;

class Magazine : CatalogueItem
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Issue { get; set; }

    public override bool Contains(string value)
    {
        return Title.Contains(value, StringComparison.InvariantCultureIgnoreCase);
    }

    public override string ToString()
    {
        return $"{Id}: Magazine: {Title} released {ReleaseDate.ToShortDateString()}. Issue {Issue}.";
    }
}