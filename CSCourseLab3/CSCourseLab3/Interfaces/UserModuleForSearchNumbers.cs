using CSCourseLab3.Forms;
using CSCourseLab3.TypeDefs;

namespace CSCourseLab3
{
    public partial class  UserModule
    {
        public static void searchNumbersInArea(Shapes formToSearch, int numberOfForm, int numberOfWay)
        {
            switch (numberOfForm)
            {
                case (int) NumberOfForms.FirstForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfFirstForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfFirstForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.SecondForm:
                {
                    switch (numberOfWay)
                    { 
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfSecondForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfSecondForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.ThirdForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfThirdForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfThirdForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.FourthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfFourthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfFourthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.FifthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfFifthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfFifthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.SixthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfSixthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfSixthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.SeventhForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfSeventhForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfSeventhForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.EighthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfEighthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfEigthtForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.NinthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfNinthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfNingthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.TenthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfTenthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfTenthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.EleventhForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfEleventhForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfEleventhForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.TwelfthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfTwelfthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfTwelfthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.ThirteenthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfThirteenthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfThirteenthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;

                case (int) NumberOfForms.FourteenthForm:
                {
                    switch (numberOfWay)
                    {
                        case (int) WaysToSearch.FindMaxElement:
                        {
                            int findedMaxElement = SearchNumbers.findMaxNumberInTheAreaOfFourteenthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMaxElement(findedMaxElement);
                        }
                            break;

                        case (int) WaysToSearch.FindMinElement:
                        {
                            int findedMinElement = SearchNumbers.findMinNumberInTheAreaOfFourteenthForm(formToSearch);
                            UserInterfaceHelpers.showFindedMinElement(findedMinElement);
                        }
                            break;
                    }
                }
                    break;
            }
        }
    }
}