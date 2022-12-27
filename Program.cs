
using System;
class Program    
{
    static void Main()
    {  
        bool isPrime = true;
        int i, j;

        Console.WriteLine("Prime numbers are from 1 --> 10");

        for (i = 2; i <= 10; i++)
        {
            for (j = 2; j <= 10; j++)
            {
                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.Write("\t" + i);
            }
            isPrime = true;
        }
        Console.ReadKey();

    }
}