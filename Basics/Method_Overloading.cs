using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Method_Overloading
    {
        // Methods Overloading = methods share same name, but different parameters
        //                       name + parameters = signature
        //                       methods must have a unique signature



        public static void Main(string[] args)
        {
            Console.WriteLine(multiply(2, 2, 2));
            Console.WriteLine(multiply(2, 2));

        }

        static double multiply(double x, double y)
        {
            return x * y;
        }

        static double multiply(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}
