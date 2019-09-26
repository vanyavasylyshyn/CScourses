using System;
using System.Diagnostics;

namespace Lab1Course
{
    internal class Program
    {
        public enum Tasks
        {
            First,
            Second,
            Third,
            Fourth,
            Fifth,
            Sixth,
            Seventh,
            EighthEvenNumbers,
            EightOddNumbers
        };
        
        public static string getNumberFromConsole(string messageToShow)
        {
            string valueToReturn;
            Console.WriteLine(messageToShow);
            valueToReturn = Console.ReadLine();
            return valueToReturn;
        }
        
        public static bool checkTheNumberForCorrectInput(string numberToCheck)
        {
            for (int i = 0; i < numberToCheck.Length; i++)
            {
                if(!Char.IsDigit(numberToCheck[i]))
                {
                    Console.WriteLine("Please, enter correct number."); 
                    return true;
                }
            }

            return false;
        }
        
        //1
        public static int checkTheNumbeOfDigitsInNumber(string number)
        {
            return number.Length;
        }
        
        //2
        public static void createArrayFromNumber(ref byte[] arrayToCreate, string number)
        {
            for (byte i = 0; i < number.Length; i++)
            {
                arrayToCreate[i] = Byte.Parse(number[i].ToString());
            }
        }
        
        //3
        public static float getArithmeticMeanByNumbers(byte[] arrayWithNumbers)
        {
            float sumOfArrayElements = 0;
            for (byte i = 0; i < arrayWithNumbers.Length; i++)
            {
                sumOfArrayElements += arrayWithNumbers[i];
            }

            float result = sumOfArrayElements / arrayWithNumbers.Length;

            return result;
        }
        
        
        //4
        public static double getGeometricMeanByNumbers(byte[] arrayWithNumbers)
        {
            
            
            double productOfNumbers = 1;
            for (byte i = 0; i < arrayWithNumbers.Length; i++)
            {
                productOfNumbers *= arrayWithNumbers[i];
            }

            double result = Math.Pow(productOfNumbers, (double)1 / arrayWithNumbers.Length);
            return result;
        }
        
        //5
        public static long getFactorial(int number)
        {
            if (number <= 1)
            {
                return 1; 
            }
            else
            {
                return number * getFactorial(number - 1); 
            }
             
        }

        //6
        public static long getSumOfEvenNumbers(int finishNumber)
        {
            long sumOfEvenNumbers = 0;
            for (int i = 0; i < finishNumber; i++)
            {
                if (i%2 == 0)
                {
                    sumOfEvenNumbers += i;
                }
            }

            return sumOfEvenNumbers;
        }
        
        //7
        public static long getSumOfOddNumbers(int finishNumber)
        {
            long sumOfOddNumbers = 0;
            for (int i = 0; i < finishNumber; i++)
            {
                if (i%2 != 0)
                {
                    sumOfOddNumbers += i;
                }
            }

            return sumOfOddNumbers;
        }
        
        //8
        public static long getSumOfEvenNumbers(int startNumber, int endNumber)
        {
            long sumOfEvenNumbers = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i%2 == 0)
                {
                    sumOfEvenNumbers += i;
                }
            }

            return sumOfEvenNumbers;
        }
        
        public static long getSumOfOddNumbers(int startNumber, int endNumber)
        {
            long sumOfOddNumbers = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i%2 != 0)
                {
                    sumOfOddNumbers += i;
                }
            }

            return sumOfOddNumbers;
        }

        public static void showValue(string valuetoShow, Tasks numberOfTask)
        {
            Console.WriteLine($"{numberOfTask}: { valuetoShow }; ");
        }

        public static void showValue(byte[] arrayFromNumber, Tasks numberOfTask)
        {
            Console.WriteLine($"{numberOfTask}:");
            for (byte i = 0; i < arrayFromNumber.Length; i++)
            {
                Console.WriteLine($"arrayFromNumber[{i}] = {arrayFromNumber[i]};");
            }
        }

        public static void Main(string[] args)
        {
            
            string stringValueN;
            int digitsInNumber = 0;
            
            stringValueN = getNumberFromConsole("Please, enter number N(integer): ");
            if (checkTheNumberForCorrectInput(stringValueN))
            {
                return;
            }
            
            int parsedToIntValue = Int32.Parse(stringValueN);
            
            //1
            digitsInNumber = checkTheNumbeOfDigitsInNumber(stringValueN);
            showValue(digitsInNumber.ToString(), Tasks.First);
            
            //2
            byte[] arrayFromNumber = new byte[digitsInNumber];
            createArrayFromNumber(ref arrayFromNumber, stringValueN);
            showValue(arrayFromNumber, Tasks.Second);
            
            //3
            float arithmeticMeanFromNumber = getArithmeticMeanByNumbers(arrayFromNumber);
            showValue(arithmeticMeanFromNumber.ToString(), Tasks.Third);
            
            //4
            double geometricMeanFromNumber = getGeometricMeanByNumbers(arrayFromNumber);
            showValue(geometricMeanFromNumber.ToString(), Tasks.Fourth);
            
            //5
            long factorialFromNumber = getFactorial(parsedToIntValue);
            showValue(factorialFromNumber.ToString(), Tasks.Fifth);
            
            //6
            long sumOfEvenNumbers = getSumOfEvenNumbers(parsedToIntValue);
            showValue(sumOfEvenNumbers.ToString(), Tasks.Sixth);
            
            //7
            long sumOfOddNumbers = getSumOfOddNumbers(parsedToIntValue);
            showValue(sumOfOddNumbers.ToString(), Tasks.Seventh);
            
            //8
            int startNumberForRange = Int32.Parse(getNumberFromConsole("Please, enter starting number for range: ")); 
            int endNumberForRange = Int32.Parse(getNumberFromConsole("Please, enter finishing number for range: "));

            long sumOfEvenNumbersByRange = getSumOfEvenNumbers(startNumberForRange, endNumberForRange);
            showValue(sumOfEvenNumbersByRange.ToString(), Tasks.EighthEvenNumbers);

            long sumOfOddNumbersByRange = getSumOfOddNumbers(startNumberForRange, endNumberForRange);
            showValue(sumOfOddNumbersByRange.ToString(), Tasks.EightOddNumbers);

        }
    }
}