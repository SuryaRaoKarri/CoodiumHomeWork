using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int flag = 0;
            var n = Double.Parse(Console.ReadLine());
            if(n > 1)
            {
                Console.Write(2+" ");
                for (int i=3; i<=n; i++)
                {
                    flag = 0;
                    for (int j=2; j<i; j++)
                    {
                        if (i % j == 0) { flag = 1; break; }
                    }
                    if (flag == 0) Console.Write(i + " ");
                }
            }
        }
    }
}
