using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class arrays
    {
        public static void Main(string[] args)
        {
            string[] dotnet = { "C#", "ASP", "ADO", "SQL" };
            for (int i = 0; i < dotnet.Length; i++)
                Console.WriteLine( dotnet[i] );
            Console.WriteLine();
            foreach(string i in dotnet)
                Console.WriteLine( i );

            Console.WriteLine();
            Array.Sort( dotnet );
            foreach(string i in dotnet)
                Console.WriteLine(i);

            Console.WriteLine();
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max()); //returns the largest value
            Console.WriteLine(myNumbers.Min()); //returns the smallest value
            Console.WriteLine(myNumbers.Sum()); //returns the sum of elements
            Console.WriteLine();


            //an array with 5 rows and 2 columns
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int k, l;
            for (k = 0; k < 5; k++)
            {
                for (l = 0; l < 2; l++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", k, l, a[k, l]);
                }
                    
            }


            Console.ReadLine();
        }
    }
}
