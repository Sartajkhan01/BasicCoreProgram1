namespace BasicCoreProgram
{
    class program
    {
        public static void Main(string[] args)
        {
            int problem = Convert.ToInt32(args[0]);


            switch (problem)
            {
                case 1:
                    PercentageOfHeadAndTails obj = new PercentageOfHeadAndTails();
                    obj.Equals(obj);
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Equals(leapYear);
                    break;
                case 3:
                    Power2 power2 = new Power2();
                    power2.Equals(power2);
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.Equals(harmonicNumber);
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.Equals(factors);
                    break;
                case 6:
                    QuetientAndRemainder quetientAndRemainder = new QuetientAndRemainder(); 
                    quetientAndRemainder.Equals(quetientAndRemainder);
                    break;
                case 7:
                    SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                    swapTwoNumbers.Equals(swapTwoNumbers);
                    break;
                case 8:
                    NumOddEven numOddEven = new NumOddEven();
                    numOddEven.Equals(numOddEven);
                    break;
                case 9:
                    VovelAndConsonant vovelAndConsonant = new VovelAndConsonant();
                    vovelAndConsonant.Equals(vovelAndConsonant);
                    break;
                case 10:
                    LargestThreeNum largestThreeNum = new LargestThreeNum();
                    largestThreeNum.Equals(largestThreeNum);
                    break;











            }
            
        }
    }
}
