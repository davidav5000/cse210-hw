using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string dav_percent = Console.ReadLine();
        int dav_percentint = int.Parse(dav_percent);

        string dav_grade = "";


        if (dav_percentint >= 90)
        {
            dav_grade = "A";
        }
        else if (dav_percentint >= 80)
        {
            dav_grade = "B";
        }
        else if (dav_percentint >= 70)
        {
            dav_grade = "C";
        }
        else if (dav_percentint >= 60)
        {
            dav_grade = "D";
        }
        else
        {
            dav_grade = "F";
        }

        Console.WriteLine($"Grade:{dav_grade}");
        
        if (dav_percentint >= 70)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}