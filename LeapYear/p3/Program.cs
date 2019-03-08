using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year:");
            double yearInp;
            var userinput = Console.ReadLine();
            bool isNum = double.TryParse(userinput, out yearInp);

            if (isNum)
            {
                if (yearInp % 400 == 0 || (yearInp % 4 == 0 && yearInp % 100 != 0)) Console.WriteLine("Leap Year");
                else Console.WriteLine("Not a Leap Year");
            }
            else Console.WriteLine("Not a number");
        }
    }
}
