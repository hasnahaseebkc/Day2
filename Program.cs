using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Peter";
            string addr = "Kannur";
            Console.WriteLine(name);
            Console.WriteLine("My name is " + name); //concatenation+
            Console.WriteLine("My name is {0} ", name); //sring interpolation{}
            Console.WriteLine("My name is {0} and I am from {1} ", name, addr);


            int c = 3 + 7;
            Console.WriteLine("c:" + c);

            double d = 6.891;
            char p = 'p';
            bool t = false;
            Console.WriteLine("double:" + d);
            Console.WriteLine("character: " + p);
            Console.WriteLine("boolean: " + t);


            //typecasting
            double one = 6.75;
            int two = (int)one;
            Console.WriteLine("explicit typecast: " + one);
            Console.WriteLine(two);


            //************** FIND GREATEST OF 3 NUMBERS *****************

            int n1, n2, n3;
            Console.WriteLine("Enter 3 numbers: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if(n1>n2)
            {
                if(n1>n3)
                        Console.WriteLine("Greatest is :" + n1);
                else
                        Console.WriteLine("Greatest is :" + n3);
            }
            else
            {
                if (n2 > n3)
                    Console.WriteLine("Greatest is :" + n2);
                else
                    Console.WriteLine("Greatest is :" + n3);
            }



            //************ SWAP 3 NUMBERS WITHOUT A 3RD VARIABLE *************

            int a, b;
            Console.WriteLine("Enter two numbers:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swap, a={0} and b={1} ",a,b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swap, a={0} and b={1} ", a, b);




            //************* GET EMPLOYEE DETAILS AND DISPLAY THEM ************

            String empid, empname, doj, jobrole;
            int pay;
            Console.WriteLine("Enter Empid, Empname, DOJ, JobRole, Pay: ");
            empid = Console.ReadLine();
            empname = Console.ReadLine();
            doj = Console.ReadLine();
            jobrole = Console.ReadLine();
            pay = int.Parse(Console.ReadLine());

            Console.WriteLine("Empid: {0}, Empname: {1}, DOJ: {2}, Job Role: {3}, Pay: {4}",empid,empname,doj,jobrole,pay);

            Console.ReadLine();



        }
    }
}
