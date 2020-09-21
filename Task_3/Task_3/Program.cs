using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;

            while (check == true)
            {
                try
                {
                    check = false;

                    Console.WriteLine("Enter a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter c: ");
                    long c = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($" Number A: {a}\n Number B: {b}\n Number C: {c}");

                }
                catch
                {
                    Console.WriteLine("Please, enter correct values!");
                    check = true;
                }
            }


        }
    }
}
