using System;
using System.Text;

namespace TrueCourseLab2
{
    class Program
    {
        static string getStringFromConsole()
        {
            Console.WriteLine("Please, enter some string: ");
            string stringFromConsole = Console.ReadLine();
            return stringFromConsole;
        }
        
        
        //3
        static byte findAmountOfRepeatingStringInAnotherString(string firstString, string secondString)
        {
            byte counterForSymbls;
            byte amountOfRepeats = 0;
            for (byte i = 0; i < firstString.Length-secondString.Length + 1; i++)
            {
                counterForSymbls = 0;
                if (firstString[i] == secondString[0])
                {
                    for (byte j = i, a = 0; a < secondString.Length; j++, a++ )
                    {
                        if (firstString[j] == secondString[a])
                        {
                            counterForSymbls++;
                        }
                    }

                    if (counterForSymbls == secondString.Length)
                    {
                        amountOfRepeats++;
                    }
                }
            }

            return amountOfRepeats;
        }
        
        //1
        static bool checkIfStringContainsEverySymbolOfAnotherString(ref string firstString, ref string secondString)
        {
            StringBuilder firstStringArray = new StringBuilder(firstString);
            StringBuilder secondStringArray = new StringBuilder(secondString);
            
            //--
            for (byte i = 0; i < firstStringArray.Length; i++)
            {
                for (byte j = 0; j < secondStringArray.Length; j++)
                {
                    if (firstStringArray[i] == '#' || firstStringArray[i] == ' ')
                    {
                        continue;
                    }
                    else if(firstStringArray[i] == secondStringArray[j])
                    {
                        
                        for (int k = i + 1; k < firstStringArray.Length; k++)
                        {
                            if (firstStringArray[k] == firstStringArray[i])
                            {
                                firstStringArray[k] = '#';
                            }
                            
                        }
                        
                        firstStringArray[i] = '#';
                        
                        for (int p = j + 1; p < secondStringArray.Length; p++)
                        {
                            if (secondStringArray[p] == secondStringArray[j])
                            {
                                secondStringArray[p] = '#';
                            }
                            
                        }
                        secondStringArray[j] = '#';
                    }
                }
            }
            //--
            
            for (byte i = 0; i < firstStringArray.Length; i++)
            {
                if (firstStringArray[i] != '#')
                {
                    return false;
                }
            }
            
            for (byte i = 0; i < secondStringArray.Length; i++)
            {
                if (secondStringArray[i] != '#')
                {
                    return false;
                }
            }

            return true;

        }
        
        //2
        static string changeAllSameSymbolsInFirstStringThatContainsSecondString(ref string firstString, ref string secondString)
        {
            StringBuilder firstStringArray = new StringBuilder(firstString);

            for (byte i = 0; i < firstStringArray.Length; i++)
            {
                for (byte j = 0; j < secondString.Length; j++)
                {
                    if (firstStringArray[i] == '#' || firstStringArray[i] == ' ')
                    {
                        continue;
                    }else if (firstStringArray[i] == secondString[j])
                    {
                        for (int k = i + 1; k < firstStringArray.Length; k++)
                        {
                            if (firstStringArray[k] == firstStringArray[i])
                            {
                                firstStringArray[k] = '#';
                            }
                            
                        }
                        
                        firstStringArray[i] = '#';
                    }
                }
            }

            return firstStringArray.ToString();
        }

        static void Main(string[] args)
        {
            string firstString = getStringFromConsole();
            string secondString = getStringFromConsole();

            bool satusOfContainingFirstStringEverySymbolOfAnotherString =
                checkIfStringContainsEverySymbolOfAnotherString(ref firstString, ref secondString);
            Console.WriteLine($"1.Status of repeating symbols in two strings: {satusOfContainingFirstStringEverySymbolOfAnotherString}");
            
            string changedFirstString = changeAllSameSymbolsInFirstStringThatContainsSecondString(ref firstString, ref secondString);
            Console.WriteLine($"2.Changed first string: {changedFirstString}");
            
            byte amountOfRepeatsAnotherString = findAmountOfRepeatingStringInAnotherString(firstString, secondString);
            Console.WriteLine($"3.Amount of repeats second string in first string: {amountOfRepeatsAnotherString}");
            
        }
    }
}