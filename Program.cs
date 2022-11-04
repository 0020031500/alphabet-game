using System;

dynamic askQuestion(string letter)
{
    string word;
    word = Console.ReadLine();
    if (word.ToLower().StartsWith(letter.ToLower()))
    {
        return word;
    }
    else
    {
        return false;
    }
}

void init(char letter, bool v2)
{
    if (!v2) Console.Clear();
    Console.WriteLine("Enter a word that starts with the letter " + letter);
    dynamic response = askQuestion(char.ToString(letter));
    if (response is string)
    {
        Console.WriteLine($"Correct! {char.ToString(letter).ToUpper()} is for {response}");
        Thread.Sleep(1000);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Incorrect, try again!");
        init(letter, true);
    }
}

void start()
{
    for (char letter = 'A'; letter <= 'Z'; letter++)
    {
        init(letter, false);
    }
    Console.WriteLine("Congratulations - you have completed the alphabet!");
}

start();
