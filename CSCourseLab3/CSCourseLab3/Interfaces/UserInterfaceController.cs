using System;
using CSCourseLab3.Forms;
using CSCourseLab3.TypeDefs;

namespace CSCourseLab3
{
    public class UserInterfaceController
    {
        public static void searchInArea(Shapes formToSearch)
        {
            Console.WriteLine("Please, choose way to search:\n" +
                              "1.Min element.\n" +
                              "2.Max element.\n" +
                              "3.Symbol.");
            int numberOfWay = Int32.Parse(Console.ReadLine());
            
            
            if (UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(numberOfWay, Config.NumberOfWaysToSearch))
            {
                //TODO винести по файлах, зробити норм перевірку чи сисла чи символи
                if (formToSearch.getTypeOfNumberArrayElemens())
                {
                    if (numberOfWay == (int)WaysToSearch.FindSymbol)
                    {
                        Console.WriteLine("!!!.Please, use this way only for number array values.");
                        return;
                    }
                    
                    Console.WriteLine("Please, choose form to search elements(from 1 to 14) or \"500\" to finish program: ");
                    int numberOfForm = Int32.Parse(Console.ReadLine());
                    UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(numberOfForm, Config.NumberOfForms);
                    UserInterfaceHelpers.checkIfWantToExitTheProgram(numberOfForm);    
                    
                    UserModule.searchNumbersInArea(formToSearch, numberOfForm, numberOfWay);
                }

                if (formToSearch.getTypeOfNumberArrayElemens() == false)
                {
                    if (numberOfWay != (int)WaysToSearch.FindSymbol)
                    {
                        Console.WriteLine("!!!.Please, use this way only for symbol array values.");
                        return;
                    }
                    Console.WriteLine("Please, choose form to search elements(from 1 to 14) or \"500\" to finish program: ");
                    int numberOfForm = Int32.Parse(Console.ReadLine());
                    UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(numberOfForm, Config.NumberOfForms);
                    UserInterfaceHelpers.checkIfWantToExitTheProgram(numberOfForm);

                    UserModule.searchSymbolsInArea(formToSearch, numberOfForm);
                }
            }

        }
        
        public static void rewriteElementsToAnotherArea(Shapes formToRewrite)
        {
            
            if (formToRewrite.getNumberOfForms() == NumberOfForms.FirstForm ||
                formToRewrite.getNumberOfForms() == NumberOfForms.SecondForm ||
                formToRewrite.getNumberOfForms() == NumberOfForms.ThirdForm ||
                formToRewrite.getNumberOfForms() == NumberOfForms.FourthForm)
            {
                Console.WriteLine("Please, choose one of forms(from 1 to 4)to rewrite in:");
                int numberOfForm = Int32.Parse(Console.ReadLine());
                UserModule.rewriteMethodForFirstShapeType(formToRewrite, numberOfForm);
            }
            else if (formToRewrite.getNumberOfForms() == NumberOfForms.FifthForm ||
                     formToRewrite.getNumberOfForms() == NumberOfForms.SixthForm)
            {
                Console.WriteLine("Please, choose one of forms(from 5 to 6)to rewrite in:");
                int numberOfForm = Int32.Parse(Console.ReadLine());
                UserModule.rewriteMethodForSecondShapeType(formToRewrite, numberOfForm);
                
            }
            else if (formToRewrite.getNumberOfForms() == NumberOfForms.SeventhForm ||
                     formToRewrite.getNumberOfForms() == NumberOfForms.EighthForm ||
                     formToRewrite.getNumberOfForms() == NumberOfForms.NinthForm ||
                     formToRewrite.getNumberOfForms() == NumberOfForms.TenthForm)
            {
                Console.WriteLine("Please, choose one of forms(from 7 to 10)to rewrite in:");
                int numberOfForm = Int32.Parse(Console.ReadLine());
                UserModule.rewriteMethodForThirdShapeType(formToRewrite, numberOfForm);
            }
            else 
            {
                Console.WriteLine("Please, choose one of forms(from 11 to 14)to rewrite in:");
                int numberOfForm = Int32.Parse(Console.ReadLine());
                
            }
        }
    }
}