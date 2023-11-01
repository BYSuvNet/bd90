namespace BD90.Model;

class Catalogue
{
    private List<ISearchable> catalogueItems = new();

    public void AddCatalogueItem(ISearchable ci)
    {
        catalogueItems.Add(ci);
    }

    public List<ISearchable> GetAllCatalogueItems()
    {
        return catalogueItems;
    }

    public List<ISearchable> Search(string searchString)
    {
        List<ISearchable> foundCatalogueItems = new();

        foreach (ISearchable item in catalogueItems)
        {
            if (item.Contains(searchString)) foundCatalogueItems.Add(item);
        }

        return foundCatalogueItems;
    }
}