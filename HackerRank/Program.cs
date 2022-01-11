using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysCodingChallene
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day 4
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }

            /*End of Day 4*/



            //Day 9
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Day9.factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

            //End of Day 9

        }
    }


}
