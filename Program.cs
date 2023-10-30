namespace BD90;

using System;
using BD90.Model;
using Spectre.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        //Här skapar vi vår katalog som hålla alla våra katalogobjekt, samt 
        //grundläggande funntionalitet i systemet, såsom att lägga till saker och söka efter saker
        Catalogue catalogue = new();

        //Testkod för att lägga till lite böcker i vår katalog
        AddRandomCatalogeItems(catalogue, 1000);

        Console.Write("sök> ");
        string searchString = Console.ReadLine();

        AnsiConsole.MarkupLine("[underline blue]RESULTAT:[/]");
        foreach (var item in catalogue.Search(searchString))
        {
            AnsiConsole.MarkupLine($"[white]{item}[/]");
        }
    }

    private static void AddRandomCatalogeItems(Catalogue catalogue, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Book newBook = new()
            {
                Author = Faker.Name.FullName(),
                PageCount = Faker.RandomNumber.Next(10, 2000),
                Title = BookNameGenerator.GenerateBookName(),
                ReleaseDate = Faker.Identification.DateOfBirth(),
                ISBN = Faker.Identification.UkNationalInsuranceNumber()
            };

            catalogue.AddCatalogueItem(newBook);
        }
    }
}