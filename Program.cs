using System;

namespace Homework_Theme_4_Source_Task_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int n = 0;
            int i;
            int j;
            
            while (n < 1 || n > 25)
            {
                Console.WriteLine("Enter N 1 to 25");
                n = int.Parse(Console.ReadLine());
            }

            int[] a = new int[n];
            int[] aShifted = new int[n + 1];
            int[] b = new int[n + 1];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    a[0] = 1;
                    aShifted[0] = 0;
                    aShifted[j + 1] = a[j];
                    b[j] = a[j] + aShifted[j];
                    a[j] = b[j];
                    Console.Write($"{a[j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
