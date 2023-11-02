namespace BD90.Model;

class Catalogue
{
    //Detta är objektet vi ska använda för att hämta och spara saker till vår katalog
    private ICatalogueRepository catalogueRepository;

    //Det faktiska objektet kommer in via konstruktorn, så det skapas med new()
    //någon annan stans
    public Catalogue(ICatalogueRepository catalogueRepository)
    {
        this.catalogueRepository = catalogueRepository;
    }

    //Innan så lade vi till saker direkt till listan, nu ger vi objektet till vårt
    //repository som får bestämma hur det ska sparas
    public void AddCatalogueItem(ISearchable ci)
    {
        catalogueRepository.Add(ci);
    }

    //Samma här, vi frågar vårt repository efter alla saker i katalogen
    public IEnumerable<ISearchable> GetAllCatalogueItems()
    {
        return catalogueRepository.GetAll();
    }

    //Sökningen frågar också repositoryt efter alla saker i katalogen så att vi kan 
    //söka bland dem
    public IEnumerable<ISearchable> Search(string searchString)
    {
        List<ISearchable> foundCatalogueItems = new();

        foreach (ISearchable item in catalogueRepository.GetAll())
        {
            if (item.Contains(searchString)) foundCatalogueItems.Add(item);
        }

        return foundCatalogueItems;
    }
}