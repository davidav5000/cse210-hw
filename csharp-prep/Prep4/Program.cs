using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> dav_numbers = new List<int>();

        int dav_num = -1;
        while (dav_num != 0)
        {
            Console.WriteLine("Enter a number (0 to quit): ");
            dav_num = int.Parse(Console.ReadLine());

            if (dav_num != 0)
            {
                dav_numbers.Add(dav_num);
            }

        }
        ///getting the sum
        int dav_sum = 0;
        foreach (int dav_number in dav_numbers)
        {
            dav_sum += dav_number;
        }
        Console.WriteLine($"The sum is: {dav_sum}");

        ///avarage 
        float dav_avarage = ((float)dav_sum) / dav_numbers.Count;
        Console.WriteLine($"The avarage is: {dav_avarage}");


        ///max
        int dav_max = dav_numbers[0];
        foreach (int dav_number in dav_numbers)
        {
            if (dav_number > dav_max)
            {
                dav_max = dav_number;
            }
        }
        Console.WriteLine($"The max is: {dav_max}");
    }


}
