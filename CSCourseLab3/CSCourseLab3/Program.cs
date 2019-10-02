using System;
using CSCourseLab3.Forms;

namespace CSCourseLab3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            FourteenthForm form = new FourteenthForm();
            form.generateElementsOfArrayByRandomNumbers();
            form.showArray();
            form.transposeArray();
            Console.WriteLine("brr");
            form.showArray();

            FirstForm first = new FirstForm();

            int maxNum = first.findMaxElementInTheAreaOfMatrix(form);
            Console.WriteLine("brr");
            Console.WriteLine(maxNum);

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