using System;
using System.Collections.Generic;

namespace CScourseLab4
{
    public class MainMenuHelper
    {
        public static void PerformApplicationAction(WorkOffer workOffer, char chosenActionForWorkOffer, Customer customer)
        {
            switch (chosenActionForWorkOffer)
            {
                case '1':
                {
                    List<ApplicationToWorkOffer> applicationsToWorkOffer = ApplicationsToWorkOfferStorage.GetApplicationsToWorkOffer(workOffer);
                    foreach (ApplicationToWorkOffer application in applicationsToWorkOffer)
                    {
                        Console.WriteLine($"{application};");
                    }
                }
                    break;

                case '2':
                {
                    Console.WriteLine("Please, enter contractor name:");
                    string enteredContractorName = Console.ReadLine();
                    
                    customer.ConfirmApplicationToWorkOffer(workOffer, enteredContractorName);
                }
                    break;
            }
        }
    }
}