using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Power2
    {
        public void Power_of_Two()
        {
            Console.Write("Please enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            while (Number < 0 || Number >= 31 )
            {
                Console.Write("Please enter a valid number: ");
                Number = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= Number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
