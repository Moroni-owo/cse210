using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------------------------------
        // EXTRA CREDIT (Creativity):
        // * Added a library of scriptures
        // * The program chooses one randomly each time it runs
        // * Helps vary the practice and makes it more realistic
        // -----------------------------------------------------

        Reference[] references = {
            new Reference("Proverbs", 3, 5, 6),
            new Reference("John", 3, 16),
            new Reference("1 Nephi", 3, 7),
            new Reference("Alma", 32, 21)
        };

        string[] texts = {
            "Trust in the Lord with all thine heart and lean not unto thine own understanding.",
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.",
            "I will go and do the things which the Lord hath commanded.",
            "Faith is not to have a perfect knowledge of things therefore if ye have faith ye hope for things which are not seen which are true."
        };

        Random random = new Random();
        int index = random.Next(references.Length);

        Scripture scripture = new Scripture(references[index], texts[index]);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (scripture.AllWordsHidden())
                break;

            scripture.HideRandomWords(3); // hides 3 words at a time
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Program ended.");
    }
}

