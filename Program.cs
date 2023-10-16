using System;

class Program
{
    static void Main(string[] args)
    {   
        // Welcoming the user to the program
        Console.WriteLine("Welcome to the scripture memorizer program!");
        Console.WriteLine("Follow the instructions below: ");
        Console.WriteLine();
        // Asking the user for the scripture reference.
        Console.Write("Enter the reference of the scripture you want to memorize (ex. '1 Nephi 2:15'): ");
        string khReference = Console.ReadLine();
        // Asking user for the scriptire passage.
        Console.Write("Enter the scripture passage (ex. 'And my father dwelt in a tent.'): ");
        string khPassage = Console.ReadLine();
        // Ask the user for the number of words hidden each time they press enter.
        Console.WriteLine("Specify the hidden word count for each memorization round (ex. '3'): ");
        string khHiddenWordCount = Console.ReadLine();
        
    }
}