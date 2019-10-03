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
                if (formToSearch.getTypeOfNumberArrayElemens())
                {
                    Console.WriteLine("Please, choose form to generate elements(from 1 to 14) or \"500\" to finish program: ");
                    int numberOfForm = Int32.Parse(Console.ReadLine());
                    UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(numberOfForm, Config.NumberOfForms);
                    UserInterfaceHelpers.checkIfWantToExitTheProgram(numberOfForm);

                    switch (numberOfForm)
                    {
                        case (int) NumberOfForms.FirstForm:
                        {
                            switch (numberOfWay)
                            {
                                case (int)WaysToSearch.FindSymbol:
                                {
                                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                                    bool statusOfSearching = SearchSymbols.findSymbolInTheAreaOfFirstForm(formToSearch, symbolToFind);
                                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                                }break;

                                case (int) WaysToSearch.FindMaxElement:
                                {
                                    char findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfFirstForm(formToSearch);
                                    UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                                }break;

                                case (int) WaysToSearch.FindMinElement:
                                {
                                    char findedMinElement = SearchNumbers.findMinNumberInTheAreaOfFirstForm(formToSearch);
                                    UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                                }break;
                            }
                        }break;
                            
                        case (int) NumberOfForms.SecondForm:
                        {
                            
                        }
                        case (int) NumberOfForms.ThirdForm:
                        {
                            
                        }
                        case (int) NumberOfForms.FourthForm:
                        {
                            
                        }
                        case (int) NumberOfForms.FifthForm:
                        {
                            
                        }
                        case (int) NumberOfForms.SixthForm:
                        {
                            
                        }
                        case (int) NumberOfForms.SeventhForm:
                        {
                            
                        }
                        case (int) NumberOfForms.EighthForm:
                        {
                            
                        }
                        case (int) NumberOfForms.NinthForm:
                        {
                            
                        }
                        case (int) NumberOfForms.TenthForm:
                        {
                            
                        }
                        case (int) NumberOfForms.EleventhForm:
                        {
                            
                        }
                        case (int) NumberOfForms.TwelfthForm:
                        {
                            
                        }
                        case (int) NumberOfForms.ThirteenthForm:
                        {
                            
                        }
                        case (int) NumberOfForms.FourteenthForm:
                        {
                            
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please, use this way only for number array values.");
                    return;
                }
            }

        }
        
        public static void rewriteElementsToAnotherArea(Shapes formToRewrite)
        {
            
            if (formToRewrite.getNumberOfForms() == NumberOfForms.FifthForm ||
                formToRewrite.getNumberOfForms() == NumberOfForms.SecondForm ||
                formToRewrite.getNumberOfForms() == NumberOfForms.ThirdForm ||
                formToRewrite.getNumberOfForms() == NumberOfForms.FourthForm)
            {
                Console.WriteLine("Please, choose one of forms(from 1 to 4)to rewrite in:");
                int numberOfForm = Int32.Parse(Console.ReadLine());
                if (UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(numberOfForm, Config.NumberOfFormsForFirstShapeType))
                {
                    
                }
            }
        }
    }
}