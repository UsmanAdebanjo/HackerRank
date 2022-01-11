using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysCodingChallene
{
    class CodingChallenge
    {
        public void Day1()
        {

        }



    }

    //Day 2
    public class Result
    {
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double a = (double)tip_percent / 100;
            double b = (double)tax_percent / 100;
            double ans = meal_cost + (a * meal_cost) + (b * meal_cost);
            Console.WriteLine("a =" + a);
            var convertedAnswer = Math.Round(ans, MidpointRounding.AwayFromZero);


            Console.WriteLine(convertedAnswer);


        }
    }

    /*End of day 2*/


    //Day 4
    public  class Person
    {
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                age = 0;
            }
            else
            {
                age = initialAge;
            }
        }
            public void amIOld()
            {
            // Do some computations in here and print out the correct statement to the console 
                if (age < 13)
                {
                    Console.WriteLine("You are young.");
                }
                else if (age >= 13 && age < 18)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are old.");
                }
            }

            public  void yearPasses()
            {
                age++;
            }
        
    }

    public class Day9
    {
        public int Age {
            get
            {
                return Age;
            }

            set
            {
                if (Age < 0)
                {
                    Age = 0;
                }
                else
                {
                    Age = value;
                }
            } 
        }
        public static int factorial(int n)
        {
            if (n > 1)
            {
                return n * factorial(n - 1);
            }

            return n;

        }
    }
}
