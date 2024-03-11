using System;

class WhilePrintDiv8
{
    static void Main(string[] args)
    {
        int i = 100;

        Console.WriteLine("\nThe numbers divisible by 8 between 100 and 300 are:\n");

        while (i <= 300)
        {
            if (i % 8 == 0)
            {
                Console.Write(i + " ");
            }
            i++;
        }

        Console.WriteLine();
    }
}
