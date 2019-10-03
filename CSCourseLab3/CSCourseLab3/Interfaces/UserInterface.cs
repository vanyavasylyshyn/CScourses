using System;
using CSCourseLab3.Forms;

namespace CSCourseLab3
{
    public class UserInterface
    {
        public static Shapes chooseFormToGenerateElements()
        {
            while (true)
            {
                Console.WriteLine("Please, choose form to generate elements(from 1 to 14) or \"500\" to finish program: ");
                int numberOfForm = Int32.Parse(Console.ReadLine());
                UserInterfaceHelpers.checkIfWantToExitTheProgram(numberOfForm);
                if (UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(numberOfForm, Config.NumberOfForms))
                {
                    switch (numberOfForm)
                    {
                        case (int) NumberOfForms.FirstForm:
                        {
                            FirstForm form = new FirstForm();
                            return form;
                        }
                        case (int) NumberOfForms.SecondForm:
                        {
                            SecondForm form = new SecondForm();
                            return form;
                        }
                        case (int) NumberOfForms.ThirdForm:
                        {
                            ThirdForm form = new ThirdForm();
                            return form;
                        }
                        case (int) NumberOfForms.FourthForm:
                        {
                            FourthForm form = new FourthForm();
                            return form;
                        }
                        case (int) NumberOfForms.FifthForm:
                        {
                            FifthForm form = new FifthForm();
                            return form;
                        }
                        case (int) NumberOfForms.SixthForm:
                        {
                            SixthForm form = new SixthForm();
                            return form;
                        }
                        case (int) NumberOfForms.SeventhForm:
                        {
                            SeventhForm form = new SeventhForm();
                            return form;
                        }
                        case (int) NumberOfForms.EighthForm:
                        {
                            EighthForm form = new EighthForm();
                            return form;
                        }
                        case (int) NumberOfForms.NinthForm:
                        {
                            NinthForm form = new NinthForm();
                            return form;
                        }
                        case (int) NumberOfForms.TenthForm:
                        {
                            TenthForm form = new TenthForm();
                            return form;
                        }
                        case (int) NumberOfForms.EleventhForm:
                        {
                            EleventhForm form = new EleventhForm();
                            return form;
                        }
                        case (int) NumberOfForms.TwelfthForm:
                        {
                            TwelfthForm form = new TwelfthForm();
                            return form;
                        }
                        case (int) NumberOfForms.ThirteenthForm:
                        {
                            ThirteenthForm form = new ThirteenthForm();
                            return form;
                        }
                        case (int) NumberOfForms.FourteenthForm:
                        {
                            FourteenthForm form = new FourteenthForm();
                            return form;
                        }
                    }
                }
                else
                {
                    continue;;
                }
            }
        }
        
        public static void chooseWayOfGeneratingElements(Shapes formToGenerateIn)
        {
            while (true)
            {
                Console.WriteLine("Please, choose way to generate elements(from 1 to 4) or \"500\" to finish program: \n" +
                                  "1.By random numbers.\n" +
                                  "2.By numbers in range.\n" +
                                  "3.By any symbols.\n" +
                                  "4.By english alphabet symbols.");
                int numberOfWay = Int32.Parse(Console.ReadLine());
                UserInterfaceHelpers.checkIfWantToExitTheProgram(numberOfWay);
                if (UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(numberOfWay, Config.NumberOfWaysToGenerateElements))
                {
                    switch (numberOfWay)
                    {
                        case (int)NumbersOfWaysToGenerateElements.ByRandomNumbers:
                        {
                            formToGenerateIn.generateElementsOfArrayByRandomNumbers();
                        }break;
                        
                        case (int)NumbersOfWaysToGenerateElements.ByNumbersInRange:
                        {
                            Console.WriteLine("Please, enter starting point for range:");
                            int startForRange = Int32.Parse(Console.ReadLine());
                            
                            Console.WriteLine("Please, enter finishing point for range:");
                            int finishForRange = Int32.Parse(Console.ReadLine());
                            
                            Console.WriteLine("Please, choose pair of odd numbers:\n" +
                                              "1.Pair.\n" +
                                              "2.Odd.");
                            int choosenTypeOfNumbers = Int32.Parse(Console.ReadLine());
                                
                            UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(choosenTypeOfNumbers,
                                Config.NumberOfTypeOfNumbers);
                            formToGenerateIn.generateElementsOfArrayByRange(startForRange, finishForRange, choosenTypeOfNumbers);
                            
                        }break;
                        
                        case (int)NumbersOfWaysToGenerateElements.ByAnySymbols:
                        {
                            formToGenerateIn.generateElementsOfArrayByAnySymbols();
                            
                        }break;
                        
                        case (int)NumbersOfWaysToGenerateElements.ByEnglishAlphabetSymbols:
                        {
                            formToGenerateIn.generateElementsOfArrayByEnglishAlphabetSymbols();
                            
                        }break;
                    }
                    break;
                }
                else
                {
                    continue;
                }    
            }
        }

        public static void chooseAction(Shapes formForAction)
        {
            while (true)
            {
                Console.WriteLine("Please, choose action or \"500\" to finish program:\n" +
                                  "1.Find min/max/symbol.\n" +
                                  "2.Transpose array in 90 degrees.\n" +
                                  "3.Rewrite elements to another area.\n" +
                                  "4.Show Array.");
                int numberOfAction = Int32.Parse(Console.ReadLine());
                UserInterfaceHelpers.checkIfWantToExitTheProgram(numberOfAction);
                if (UserInterfaceHelpers.checkTheCorrectInputNumberOfForm(numberOfAction, Config.NumberOfActions))
                {
                    switch (numberOfAction)
                    {
                        case (int)NumberOfActions.SearchInArray:
                        {
                            UserInterfaceController.searchInArea(formForAction);
                        //TODO перевірку чи числовий арей чи ні і яку хоче область
                        }break;
                    
                        case (int)NumberOfActions.TransposeeArray:
                        {
                            formForAction.transposeArray();
                        }break;
                    
                        case (int)NumberOfActions.RewriteElementsToAnotherArea:
                        {
                            UserInterfaceController.rewriteElementsToAnotherArea(formForAction);
                        }break;
                    
                        case (int)NumberOfActions.ShowArray:
                        {
                            formForAction.showArray();
                        }break;
                    }
                }   
            }
        }
    }
}