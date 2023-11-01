namespace BD90.Model;

class Catalogue
{
    private List<CatalogueItem> catalogueItems = new();

    public void AddCatalogueItem(CatalogueItem ci)
    {
        catalogueItems.Add(ci);
    }

    public List<CatalogueItem> GetAllCatalogueItems()
    {
        return catalogueItems;
    }

    public List<CatalogueItem> Search(string searchString)
    {
        List<CatalogueItem> foundCatalogueItems = new();

        foreach (CatalogueItem item in catalogueItems)
        {
            if (item.Contains(searchString)) foundCatalogueItems.Add(item);
        }

        return foundCatalogueItems;
    }
}