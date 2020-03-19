using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_degree
{
    public static class Degrees
    {
        static double Degree_2 (double number)
        {
            Console.WriteLine(number * number);
            return number * number;
        }

        static double Degree_3(double number)
        {
            Console.WriteLine(number * number * number);
            return number * number * number;
        }
        
        static double Degree_4(double number)
        {
            Console.WriteLine(number * number * number * number);
            return number * number * number * number;
        }
    }
}
