using System;
using CSCourseLab3.TypeDefs;

namespace CSCourseLab3.Forms
{
    public class UserInterfaceHelpers
    {
        public static bool checkTheCorrectInputNumberOfForm(int input,int finishRangeOfChecking)
        {
            if (input < 1 || input > finishRangeOfChecking)
            {
                Console.WriteLine("Please, enter correct number of form(from 1 to 14) or zero to finish program.");
                return false;
            }

            return true;
        }

        public static void checkIfWantToExitTheProgram(int statusNumber)
        {
            if (statusNumber == 500)
            {
                Environment.Exit(0);
            }
        }

        public static char getSymbolFromConsole()
        {
            Console.WriteLine("Please, enter symbol to search: ");
            char symbolToFind = Char.Parse(Console.ReadLine());
            return symbolToFind;
        }

        public static void showFindedSymbol(bool statusOfSearching)
        {
            Console.WriteLine($"Status of searching: {statusOfSearching}");
        }

        public static void showFindedMaxElement(char findedMaxElement)
        {
            Console.WriteLine($"Finded max element: {findedMaxElement}");
        }
        
        public static void showFindedMinElement(char findedMaxElement)
        {
            Console.WriteLine($"Finded min element: {findedMaxElement}");
        }
        
    }
}