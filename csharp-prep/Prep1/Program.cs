using System;

class Program
{
    static void Main(string[] args) //always start with main//
    {
        //how you are meant to print//
        Console.Write("What is you first name? ");
        string dav_firstname = Console.ReadLine();

        Console.Write("What is you last name? ");
        string dav_lastname = Console.ReadLine();

        Console.WriteLine($"You name is {dav_lastname}, {dav_firstname} {dav_lastname}.");

    }
}

