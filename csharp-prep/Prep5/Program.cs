using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string dav_user_name = PromptUserName();
        int dav_user_num = PromptUserNumber();
        int dav_squared = SquareNumber(dav_user_num);
        int dav_birth_year;
        PromptUserBirthYear(out dav_birth_year);

        DisplayResult(dav_user_name, dav_squared, dav_birth_year);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string dav_name = Console.ReadLine();
        return dav_name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int dav_number = int.Parse(Console.ReadLine());
        return dav_number;
    }
    static void PromptUserBirthYear(out int dav_birth_year)
    {
        Console.Write($"Please enter the year you were born: ");
        dav_birth_year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int dav_number)
    {
        int dav_square_num = dav_number * dav_number;
        return dav_square_num;
    }

    static void DisplayResult(string dav_name, int dav_square_num, int dav_birth_year)
    {
        Console.WriteLine($"{dav_name}, the square of your number is {dav_square_num}.");
        Console.WriteLine($"{dav_name}, you will turn {2026 - dav_birth_year} years old this year.");
    }
}