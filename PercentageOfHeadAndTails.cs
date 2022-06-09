using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PercentageOfHeadAndTails
    {
        private static int tails;

        public static void main(String[] args)
        {
            int loopCount = 1;
            int numFlips = 10;
            double result;
            int heads = 0;

            while (loopCount < numFlips)
            {
                result = Math.random();
                if (result <= .5) { heads++; }
                loopCount++;
            }

            double percentHeads = heads / numFlips * 100;
            double percentTails = (numFlips - tails) / numFlips * 100;
        }
    }
}


