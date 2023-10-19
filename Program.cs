using System;

class Program {
        static void Main(string[] args)
    {   
        // Welcoming the user to the program
        Console.WriteLine("Welcome to the scripture memorizer program!");
        Console.WriteLine("Follow the instructions below: ");
        Console.WriteLine();

        // Asking the user for the scripture reference.
        Console.Write("Enter the reference of the scripture you want to memorize (ex. '1 Nephi 2:15'): ");
        string khReference = Console.ReadLine();

      
        
        // Pass information to finished reference class method here.

        // Asking user for the scriptire passage.
        Console.Write("Enter the scripture passage (ex. 'And my father dwelt in a tent.'): ");
        string khPassage = Console.ReadLine();

        
        // Pass information to finished scripture class method here.

        // Ask the user for the number of words hidden each time they press enter.
        Console.Write("Specify the hidden word count for each memorization round. (ex. '3'): ");
        string khHiddenWordCount = Console.ReadLine();
        int khNumberHiddenWords = int.Parse(khHiddenWordCount);

        Memorizer khMainMemorizer = new Memorizer(khReference, khPassage, khNumberHiddenWords);

        do{
            khMainMemorizer.EesUpdateVerse();
            Console.Clear();
            khMainMemorizer.ToString();
            Console.Write("Press the spacebar to continue: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Spacebar) {
                continue;
            }
            string UserResponse = Console.ReadLine();
            if (UserResponse.ToLower() == "quit"){
                break;
            }
        }while (khMainMemorizer.IsDone() == false);

        // Pass information to finished Memorizer class method here.
    }
}