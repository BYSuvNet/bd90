namespace BD90.Model;

// Detta är basklassen för alla objekt vi lagrar i vår bibliotekskatalog.
// Alla klasser som ärver från denna klass kan användas i vår katalog.

abstract class CatalogueItem
{
    public int Id { get; set; }

    public CatalogueItem()
    {
        Id = new Random().Next(100000);
    }

    //Denna metod används för att söka efter något i ett katalogobjekt.
    //Denna metod är abstrakt, vilket betyder att den _måste_ overridas av en subklass.
    public abstract bool Contains(string value);

    //Genom att overrida ToString från object-basklassen så kan vi göra den abstract 
    //och därmed tvinga alla subklasser att implementera ToString()
    public abstract override string ToString();
}