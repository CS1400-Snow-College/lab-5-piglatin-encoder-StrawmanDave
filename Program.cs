// David Barlow 10/13/24 lab-5 Piglatin encoder

Console.Clear();

// greeting and description
Console.WriteLine("Welcome to the Piglatin encoder anything you say will be put into Piglatin and encoded");
Console.WriteLine("Please give me a few words or sentences");
string phrase = Console.ReadLine();

//phrase split into words
string[] wordArray =phrase.Split (' ');
Console.WriteLine("Your new phrase for now is");
for(int i = 0; i<wordArray.Length; i++)
{
    Console.Write($"{wordArray[i]}");
}

//So that there is a space
Console.WriteLine();