
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class looping
    {
        public static void Main()
        {
            int num,sum=0;
            Console.WriteLine("Enter a number :");
            num=int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
                sum = sum + i;
            Console.WriteLine(sum);


            //CALCULATOR

            int op, a, b;
            float res;
            Console.WriteLine("Enter 2 numbers: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number(1-4)(add,sub,mul,div): ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1: res = a + b;
                        Console.WriteLine("The Result of addition is: {0} ", res);
                        break;
                case 2: res = a - b;
                        Console.WriteLine("The Result of subtraction is: {0} ", res);
                        break;
                case 3: res = a * b;
                        Console.WriteLine("The Result of multiplication is: {0} ", res); 
                        break;
                case 4: res = a / b;
                        Console.WriteLine("The Result of division is: {0} ", res); 
                        break;
                default: Console.WriteLine("Invalid operator"); break;

            }
            
            Console.ReadLine();

        }
    }
}
