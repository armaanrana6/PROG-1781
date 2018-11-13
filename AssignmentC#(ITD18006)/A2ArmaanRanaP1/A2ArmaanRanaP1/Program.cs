using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ArmaanRanaP1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double tuition, registration, tax , total ;
            Console.WriteLine("International Student (Yes or No) ");
            string student = Console.ReadLine();
            Console.WriteLine("Enter age ");
            string ag = Console.ReadLine();
            int age = int.Parse(ag);
              Console.WriteLine("Registration month");
           string month = Console.ReadLine();
           

            Console.WriteLine("Student's Age  " + age);
            Console.WriteLine("International Student (or not)" + student);

            
           
            if (student == "No")
            {
                if (age <= 18)
                {
                    tuition = 300 + (0.13* 300);
                    Console.WriteLine("Base Tution $" + tuition);
                }

                else if  (age <= 49)
                {
                    tuition = 500 + (0.13* 500);
                    Console.WriteLine("Base Tution $" + tuition);
                }
                else if (age >= 50)
                {
                    tuition = 400 + (0.13 * 400);
                    Console.WriteLine("Base Tution $" + tuition);

                }
            }
           else if (student == "Yes")
            {

                if (age <= 18)
                {
                    tuition = 100 + 300 + (0.13 * 300);
                    Console.WriteLine("International Student Fee $" + tuition);
                }

                if (age>=19 && age <= 49)
                {
                    tuition =100 + 500 + (0.13 * 500);
                    Console.WriteLine("International Student Fee $" + tuition);
                }
                if (age >= 50)
                {
                    tuition = 100 + 400 + (0.13 * 400);
                    Console.WriteLine("International Student Fee $" + tuition);

                }
            }
            else
            {
                Console.WriteLine("Enter Yes or No");
            }


            switch (month)
            {
                case "September":
                    {

                        Console.WriteLine("Registration Semester : Fall");
                        registration = 250 + (0.13 * 250);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 250 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "October":
                    {
                        Console.WriteLine("Registration Semester : Fall");
                        registration = 250 + (0.13 * 250);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 250 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "November":
                    {
                        Console.WriteLine("Registration Semester : Fall");
                        registration = 250 + (0.13 * 250);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 250 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "December":
                    {
                        Console.WriteLine("Registration Semester : Fall");
                        registration = 250 + (0.13 * 250);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 250 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "January":
                    {
                        Console.WriteLine("Registration Semester : Winter");
                        registration = 220 + (0.13 * 220);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 220 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "February":
                    {
                        Console.WriteLine("Registration Semester : Winter");
                        registration = 220 + (0.13 * 220);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 220 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "March":
                    {

                        Console.WriteLine("Registration Semester : Winter");
                        registration = 220 + (0.13 * 220);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 220 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "April":
                    {
                        Console.WriteLine("Registration Semester : Winter");
                        registration = 220 + (0.13 * 220);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 220 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }

                case "May":
                    {
                        Console.WriteLine("Registration Semester : Summer");
                        registration = 150 + (0.13 * 150);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 150 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "June":
                    {
                        Console.WriteLine("Registration Semester : Summer");
                        registration = 150 + (0.13 * 150);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 150 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "July":
                    {
                        Console.WriteLine("Registration Semester : Summer");
                        registration = 150 + (0.13 * 150);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 150 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "August":
                    {
                        Console.WriteLine("Registration Semester : Summer");
                        registration = 150 + (0.13 * 150);
                        Console.WriteLine("Registration Fee for semester $" + registration);
                        tax = 150 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Enter valid Semester");
                        break;
                    }


            }
           /* total = tax + tuition + registration ;
            Console.WriteLine("Total Fee " +total );
            */


        }
    }
}