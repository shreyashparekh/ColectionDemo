using System;

namespace Day2
{
    class Program
    {
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double d = 1E1;
            int a = 'b';
            int[,,] array1 = new int[4, 2, 3];
            int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //Console.WriteLine(Enum.GetValues(Months));
            //Console.WriteLine(a);
            for(int i=0;i<array4.Length;i++)
            {
                Console.WriteLine(array4[i, 0]);
                Console.WriteLine(array4[i,1]);
            }
        }
    }
}
