using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char character = Convert.ToChar(Console.ReadLine().ToLower());

        switch (character)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("It is a vowel");
                break;

            default:
                Console.WriteLine("It is a consonant");
                break;
        }
    }
}