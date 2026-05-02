using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int dav_mag_num = randomGenerator.Next(1, 101);

        int dav_guess = 0;


        while (dav_mag_num != dav_guess)

        {   
            Console.WriteLine("What is you guess? ");
            dav_guess = int.Parse(Console.ReadLine());


            if (dav_mag_num > dav_guess)
            {
                Console.WriteLine("Higher");
            }
            else if (dav_mag_num < dav_guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed it!");
            }

        }

    }
}