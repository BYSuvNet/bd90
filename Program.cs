namespace BD90;

using System;
using BD90.Model;
using Spectre.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        RandomCatalogueRepository randomCatalogueRepository = new();

        //Här skapar vi vår katalog som hålla alla våra katalogobjekt, samt 
        //grundläggande funntionalitet i systemet, såsom att lägga till saker och söka efter saker
        Catalogue catalogue = new(randomCatalogueRepository);

        Console.Write("sök> ");
        string searchString = Console.ReadLine();

        Table table = new();
        table.AddColumn(new TableColumn("Title"));
        table.AddColumn(new TableColumn("Author"));
        table.AddColumn(new TableColumn("ISBN"));

        AnsiConsole.MarkupLine("[underline blue]RESULTAT:[/]");
        foreach (ISearchable item in catalogue.Search(searchString))
        {
            if (item is Book b)
            {
                table.AddRow(b.Title, b.Author, b.ISBN);
            }
        }

        AnsiConsole.Write(table);
    }
}