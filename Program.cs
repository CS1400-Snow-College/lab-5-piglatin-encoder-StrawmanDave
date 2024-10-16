// David Barlow 10/13/24 lab-5 Piglatin encoder

Console.Clear();

// greeting and description
Console.WriteLine("Welcome to the Piglatin encoder anything you say will be put into Piglatin and encoded");
Console.WriteLine("Please give me a few words or sentences");
string phrase = Console.ReadLine();

//phrase split into words
string[] wordArray = phrase.Split(' ');
int letterMove = 0;

Random rand = new Random();
int offSet = rand.Next(1,26);
char letter = (char)97;
letter = (char)((int)letter + offSet);

for(int i = 0; i<wordArray.Length; i++)
{

while(!"aeiou".Contains(wordArray[i][0])) // while the first letter is not a vowel
{
    wordArray[i] = wordArray[i].Substring(1) + wordArray[i][0]; //take the first letter and move it to the back.
    letterMove ++; // checks if the first letter got moved at all
}
    if(letterMove > 0) // if the letter did get move the word started with a consonant 
    {
        wordArray[i] = wordArray[i] + "ay ";
    }else // if it did not then the word started with a vowel
    {
        wordArray[i] = wordArray[i] + "way ";
    }
    Console.Write(wordArray[i]);
    letterMove = 0;  //resets the counter for the next word.
}
// space for the encription
Console.WriteLine();

// new array for encripting
string[] encript = wordArray;
for(int f = 0; f<encript.Length; f++)
{
    //takes char in the string and offests it then prints it back out
    for(int j = 0; j<encript[f].Length; j++)
    {
        //if the letter or char is a space ignore it.
        letter = encript[f][j];
        if(" ".Contains(letter))
        {
            letter = encript[f][j];

        }else //randomly offset each letter.
        {
            int letterLoop = letter + offSet;
            while(letterLoop > 122)
            {
                int remain = letterLoop % 122;
                letterLoop = 97 + remain;

            }
            letter = (char)((int)letterLoop);
        }
        
        Console.Write(letter);
    }
}

//So that there is a space
Console.WriteLine();