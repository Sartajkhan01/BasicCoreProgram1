using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Factors
    {
        public void Factor()
        {
            Console.WriteLine("Enter the number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Factors for [0] are, ", Number);

            for (int i = 2; 1 * i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
