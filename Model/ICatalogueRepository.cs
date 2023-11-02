namespace BD90.Model;

//Vårt interface som definierar hur Catalogen kan prata med klasser som lagrar data

interface ICatalogueRepository
{
    void Add(ISearchable searchable);
    IEnumerable<ISearchable> GetAll();
}