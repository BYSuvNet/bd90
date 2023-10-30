namespace BD90;

using System;
using BD90.Model;
using Spectre.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Catalogue catalogue = new();

        AddRandomCatalogeItems(catalogue);

        Console.Write("sök> ");
        string searchString = Console.ReadLine();

        AnsiConsole.MarkupLine("[underline red]RESULTAT:[/]");
        foreach (var item in catalogue.Search(searchString))
        {
            AnsiConsole.MarkupLine($"[white]{item}[/]");
        }
    }

    private static void AddRandomCatalogeItems(Catalogue catalogue)
    {
        for (int i = 0; i < 1000; i++)
        {
            Book newBook = new();
            newBook.Author = Faker.Name.FullName();
            newBook.PageCount = Faker.RandomNumber.Next(10, 2000);
            newBook.Title = Faker.Internet.UserName();
            newBook.ReleaseDate = Faker.Identification.DateOfBirth();
            newBook.ISBN = Faker.Identification.UkNationalInsuranceNumber();

            catalogue.AddCatalogueItem(newBook);
        }
    }
}