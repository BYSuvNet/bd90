namespace BD90.Model;

class CatalogueItem
{
    public int Id { get; set; }

    public CatalogueItem()
    {
        Id = new Random().Next(100000);
    }

    public virtual bool Contains(string value)
    {
        return Id.ToString().Contains(value, StringComparison.InvariantCultureIgnoreCase);
    }
}

// 12 -> "12" 
// innehåller "12" -> "sagan" = false
// inenhåller "12" -> "1" = true