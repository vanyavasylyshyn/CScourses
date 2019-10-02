using System;
using CSCourseLab3.Forms;

namespace CSCourseLab3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            FirstForm first = new FirstForm();
            first.generateElementsOfArrayByAnySymbols();
            first.showArray();
            Console.WriteLine("brr");
            Console.Write(SearchSymbols.findSymbolInTheAreaOfTenthForm(first, '='));
            Console.WriteLine("brr");
            Console.WriteLine(SearchNumbers.findMaxNumberInTheAreaOfFirstForm(first));

            /*
            while (true)
            {
                Console.WriteLine("Please, choose one of shapes to fill in or zero to finish program.");
                string formNumber = Console.ReadLine();
                switch (formNumber)
                {
                    case TypesOfForms.typesOfForms.FirstShape:
                }
            }
            */
        }
    }
}