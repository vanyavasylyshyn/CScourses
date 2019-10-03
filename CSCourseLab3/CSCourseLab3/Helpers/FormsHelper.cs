using System;

namespace CSCourseLab3.Forms
{
    public class FormsHelper
    {
        public static int generatePairNumbersInRange(int startingRangePoint, int finishingRangePoint)
        {
            Random random = new Random();
            while (true)
            {
                int number = random.Next(startingRangePoint, finishingRangePoint);
                if (number % 2 == 0)
                {
                    return number;
                }
            }
        }
    
        public static int generateOddNumbersInRange(int startingRangePoint, int finishingRangePoint)
        {
            Random random = new Random();
            while (true)
            {
                int number = random.Next(startingRangePoint, finishingRangePoint);
                if (number % 2 != 0)
                {
                    return number;
                }
            }
        }
        
    }
}