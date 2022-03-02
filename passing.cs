using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class passing
    {
        public void swap1(int x, int y) //pass by value
        {
            int c = x;
            x = y;
            y = c;
            Console.WriteLine("In Method, x={0} & y={1}",x,y);
        }


        public void swap2(ref int x, ref int y)     //pass by reference
        {
            int c = x;
            x = y;
            y = c;
            Console.WriteLine("In method, x={0} & y={1}", x, y);
        }

        public void swap3(out int x,out int y)      //pass by output
        {
            x = 30*2;
            y = 20 + 5;
            Console.WriteLine("In method, x={0} & y={1}", x, y);
        }



        static void Main(string[] args)
        {
            passing o = new passing();
            passing p = new passing();
            passing q = new passing();
            int a = 10;
            int b = 30;
            Console.WriteLine("a={0} & b={1}", a, b);
            o.swap1(a, b);
            Console.WriteLine("In main, a={0} & b={1}", a, b);


            Console.WriteLine("a={0} & b={1}", a, b);
            p.swap2(ref a, ref b);
            Console.WriteLine("In main, a={0} & b={1}", a, b);

            Console.WriteLine("a={0} & b={1}", a, b);
            q.swap3(out a, out b);
            Console.WriteLine("In main, a={0} & b={1}", a, b);
            Console.ReadLine();
        }
    }
}
