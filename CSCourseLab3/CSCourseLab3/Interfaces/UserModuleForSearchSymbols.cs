using CSCourseLab3.Forms;

namespace CSCourseLab3
{
    public partial class UserModule
    {
        public static void searchSymbolsInArea(Shapes formToSearch, int numberOfForm)
        {
            switch (numberOfForm)
            {
                case (int) NumberOfForms.FirstForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfFirstForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.SecondForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfSecondForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.ThirdForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfThirdForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;
                    
                case (int) NumberOfForms.FourthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfFourthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;
                
                case (int) NumberOfForms.FifthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfFifthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.SixthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfSixthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.SeventhForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfSeventhForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.EighthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfEghthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.NinthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfNinthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.TenthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfTenthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.EleventhForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfEleventhForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.TwelfthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfTwelfthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.ThirteenthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfThirteenthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;

                case (int) NumberOfForms.FourteenthForm:
                {
                    char symbolToFind = UserInterfaceHelpers.getSymbolFromConsole();
                    bool statusOfSearching =
                        SearchSymbols.findSymbolInTheAreaOfFourteenthForm(formToSearch, symbolToFind);
                    UserInterfaceHelpers.showFindedSymbol(statusOfSearching);
                }
                    break;
            }
        }
    }
}