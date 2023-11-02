using BD90.Model;

namespace BD90;

class DapperCatalogueRepository : ICatalogueRepository
{
    public void Add(ISearchable searchable)
    {
        Console.WriteLine("'! NOT IMPLEMENTED, NOTHING ADDED.");
    }

    public IEnumerable<ISearchable> GetAll()
    {
        Console.WriteLine("'! NOT IMPLEMENTED, EMPTY LIST RETURNED.");
        return new List<ISearchable>();
    }
}