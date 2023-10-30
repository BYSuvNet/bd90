using System;
using System.Collections.Generic;

public static class BookNameGenerator
{
    private static readonly Random rng = new Random();
    private static readonly List<string> adjectives = new List<string>
    {
        "Mysterious", "Dark", "Epic", "Forgotten", "Hidden",
        "Lost", "Secret", "Enchanted", "Silent", "Ethereal",
        "Ancient", "Cursed", "Damned", "Forgotten", "Haunted",
        "Magical", "Mystical", "Mythical", "Sacred", "Shadowy",
        "Supernatural", "Unholy", "Unspeakable", "Wicked",
        "Wondrous", "Enigmatic", "Eternal", "Fabled"
    };

    private static readonly List<string> nouns = new List<string>
    {
        "Kingdom", "Forest", "Mountain", "River", "Ocean",
        "Canyon", "Witch", "Warrior", "Dragon", "Castle",
        "Sword", "Shield", "Knight", "Princess", "Prince",
        "Wizard", "Sorcerer", "Sorceress", "Mage"

    };

    private static readonly List<string> ofPhrases = new List<string>
    {
        "of Shadows", "of the Lost Realm", "of Destiny", "of the Enchanted",
        "of Time", "of the Forgotten", "of Dreams", "of the Damned",
        "of the Ancient", "of Eternity", "of the Cursed", "of the Wicked",
        "of the Sacred", "of the Unholy", "of the Unspeakable"
    };

    public static string GenerateBookName()
    {
        var format = rng.Next(3);
        string bookName = string.Empty;

        switch (format)
        {
            case 0:
                // Format: Adjektiv + Substantiv
                bookName = $"{PickRandom(adjectives)} {PickRandom(nouns)}";
                break;
            case 1:
                // Format: Adjektiv + Substantiv + "of blablba"
                bookName = $"{PickRandom(adjectives)} {PickRandom(nouns)} {PickRandom(ofPhrases)}";
                break;
            case 2:
                // Format: Substantiv + "of blablba"
                bookName = $"{PickRandom(nouns)} {PickRandom(ofPhrases)}";
                break;
        }

        return bookName;
    }

    private static string PickRandom(List<string> list)
    {
        return list[rng.Next(list.Count)];
    }
}