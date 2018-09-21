using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            display();
            

        }
        static void display()
        {
            double a = 100;
            double b = 20;
            double c = 80;
            double avg;
            /*string a1,b1,c1;
            a1 = a.ToString();
            b1 = b.ToString();
            c1 = c.ToString();
            int a2;
            int b2;
            int c2;

            a2 = int.Parse(a1);
            b2 = int.Parse(b1);
            c2 = int.Parse(c1);*/
            avg = (a+b+c)/3;
            Console.WriteLine("Average of 100,20 and 80 is" +avg);

        }
    }
}
