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
                    List<ApplicationToWorkOffer> applicationsToWorkOffer = workOffer._ApplicationToWorkOffers;
                    
                    foreach (ApplicationToWorkOffer application in applicationsToWorkOffer)
                    {
                        application.ShowApplicationInformation();
                    }
                }
                    break;

                case '2':
                {
                    Console.WriteLine("Please, enter contractor name:");
                    string enteredContractorName = Console.ReadLine();
                    
                    Console.WriteLine("Please, enter contractor surname:");
                    string enteredContractorSurname = Console.ReadLine();
                    
                    customer.ConfirmApplicationToWorkOffer(workOffer, enteredContractorName, enteredContractorSurname);
                }
                    break;
            }
        }

        public static void ShowWorkOffers()
        {
            List<WorkOffer> workOffers = WorkOffersStorage.GetWorkOffers();

            foreach (WorkOffer offer in workOffers)
            {
                offer.ShowWorkOfferInformation();
            }
        }
    }
}