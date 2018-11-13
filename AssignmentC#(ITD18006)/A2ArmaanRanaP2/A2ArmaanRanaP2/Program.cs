using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ArmaanRanaP2
{
    class Program
    {
        static double sphere(double r)
        {
            double sphere;
            sphere = 4 / 3 * 3.14 * r * r * r;
            return sphere;
        }
        static double sphere(double r, double h)
        {
            double sphere;
            sphere = 3.14 * r * r * h;
            return sphere;
        }
        static double sphere(int l, int b, int h)
        {
            double sphere;
            sphere = l * b * h;
            return sphere;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Select the type of Shape");
            Console.WriteLine("1:Sphere");
            Console.WriteLine("2:Cylinder");
            Console.WriteLine("3:Rectangular Prism");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            if (y == 1)
            {
                Console.WriteLine("enter the value of radius");
                string u = Console.ReadLine();
                double r = double.Parse(u);
                double result;
                result = sphere(r);
                Console.WriteLine("Volume of sphere = " + result);
            }
            else if (y == 2)
            {
                Console.WriteLine("enter the value of radius");
                string i = Console.ReadLine();
                double r = double.Parse(i);
                Console.WriteLine("enter the value of height");
                string k = Console.ReadLine();
                double h = double.Parse(i);
                double res;
                res = sphere(r, h);
                Console.WriteLine("Volume of cylinder =" + res);
            }
            else if (y == 3)
            {
                Console.WriteLine("enter the length of rectangle");
                string a = Console.ReadLine();
                int l = int.Parse(a);
                Console.WriteLine("enter the breadth of rectangle");
                string c = Console.ReadLine();
                int b = int.Parse(c);
                Console.WriteLine("enter the height of rectangle");
                string d = Console.ReadLine();
                int h = int.Parse(d);
                double resu;
                resu = sphere(l, b, h);
                Console.WriteLine("Volume of rectangular prism is " + resu);
            }
        }
    }
}
    