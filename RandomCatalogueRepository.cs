using BD90.Model;

namespace BD90;

/*
    Den här klassen är en av möjligen flera i vår applikation. Den har en viss
    implementation av hur objekt ska lagras och hämtas. Just den här klassen lagrar
    objekten i en lista. Den fyller även på listan med random grejer när den skapas första
    gången. 
*/

class RandomCatalogueRepository : ICatalogueRepository
{
    private List<ISearchable> searchables = new();

    //Här i konstruktorn slumpar vi fram en massa objekt och lagrar dom i listan
    public RandomCatalogueRepository()
    {
        for (int i = 0; i < 1000; i++)
        {
            Book newBook = new()
            {
                Author = Faker.Name.FullName(),
                PageCount = Faker.RandomNumber.Next(10, 2000),
                Title = BookNameGenerator.GenerateBookName(),
                ReleaseDate = Faker.Identification.DateOfBirth(),
                ISBN = Faker.Identification.UkNationalInsuranceNumber()
            };

            searchables.Add(newBook);
        }

        for (int i = 0; i < 500; i++)
        {
            Magazine magazine = new()
            {
                Title = "Gus Allt om " + Faker.Country.Name(),
                Issue = Faker.RandomNumber.Next(1, 13)
            };

            searchables.Add(magazine);
        }
    }

    //Denna metod måste finnas enligt interfaces ICatalogueRepository, och används
    //i vår Catalogue-klass.
    public void Add(ISearchable searchable)
    {
        searchables.Add(searchable);
    }

    //Denna metod måste finnas enligt interfaces ICatalogueRepository, och används
    //i vår Catalogue-klass.
    public IEnumerable<ISearchable> GetAll()
    {
        return searchables;
    }
}