namespace BD90.Model;

// Detta är basklassen för alla objekt vi lagrar i vår bibliotekskatalog.
// Alla klasser som ärver från denna klass kan användas i vår katalog.

class CatalogueItem
{
    public int Id { get; set; }

    public CatalogueItem()
    {
        Id = new Random().Next(100000);
    }

    //Denna metod används för att söka efter något i ett katalogobjekt.
    //Denna metod är virtuell, vilket betyder att den kan overridas av en subklass.
    public virtual bool Contains(string value)
    {
        return Id.ToString().Contains(value, StringComparison.InvariantCultureIgnoreCase);
    }
}