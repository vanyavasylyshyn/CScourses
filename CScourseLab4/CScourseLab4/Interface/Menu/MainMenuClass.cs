using System;
using System.Collections.Generic;

namespace CScourseLab4
{
    public static class MainMenuInterface
    {
        delegate void ShowOffers();
        /// <summary>
        /// Method used for confirm chosen action by customer.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="choosenAction"></param>
        /// <returns></returns>
        public static bool CompleteActionForCustomer( User user, char choosenAction)
        {
            Customer customer = (Customer) user;

            switch (choosenAction)
            {
                case '1':
                {
                    customer.CreateWorkOffer();
                }
                    break;
                
                case '2':
                {
                    var workOffers = WorkOffersStorage.GetWorkOffers(customer);
                    
                    foreach (WorkOffer workOffer in workOffers)
                    {
                        workOffer.ShowWorkOfferInformation();
                    }
                }
                    break;
                
                case '3':
                {
                    Console.WriteLine("Please, enter work offer name:");
                    string enteredWorkOfferName = Console.ReadLine();
                    
                    var workOffer = WorkOffersStorage.GetWorkOffer(enteredWorkOfferName);
                    
                    Console.WriteLine("Selected work offer:\n" +
                                      $"{workOffer}");
                    
                    Console.WriteLine("Please, choose action:\n" +
                                      "1.Show applications to work offer.\n" +
                                      "2.Confirm application.");
                    
                    char chosenActionForWorkOffer = Char.Parse(Console.ReadLine());

                    MainMenuHelper.PerformApplicationAction(workOffer, chosenActionForWorkOffer, customer);
                    
                }
                    break;
                
                case '4':
                {
                    Authentication.LogOut();
                    return Constants.IfUserWantLogOut;
                }
            }

            return Constants.IfUserWantContinue;
        }
        
        /// <summary>
        /// Method used for confirm chosen action by administrator.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="choosenAction"></param>
        /// <returns></returns>
        public static bool CompleteActionForAdministrator( User user, char choosenAction)
        {
            Administrator administrator = (Administrator) user;
            
            ShowOffers showOffers = MainMenuHelper.ShowWorkOffers;
            
            switch (choosenAction)
            {
                case '1':
                {
                    List<Contractor> findedContractors =  UserStorage.GetUnverifyedContractors();

                    foreach (Contractor contractor in findedContractors)
                    {
                        contractor.ShowInformation();
                    }
                }
                    break;
                
                case '2':
                {
                    Console.WriteLine("Please, enter contractor's' name.");
                    string enteredContractorName = Console.ReadLine();
                    
                    Console.WriteLine("Please, enter contractor's' surname.");
                    string enteredContractorSurname = Console.ReadLine();

                    Contractor findedContractor =
                        UserStorage.GetUserByNameAndSurname(enteredContractorName, enteredContractorSurname);
                    
                    findedContractor.VerifyContractor();
                }
                    break;
                
                case '3':
                {
                    showOffers();
                }
                    break;
                
                case '4':
                {
                    Console.WriteLine("Please, enter work offer name:");
                    string enteredWorkOfferName = Console.ReadLine();
                    
                    var workOffer = WorkOffersStorage.GetWorkOffer(enteredWorkOfferName);
                    
                    workOffer.CloseWorkOffer();
                }
                    break;
                
                case '5':
                {
                    Authentication.LogOut();
                    return Constants.IfUserWantLogOut;
                }
                    break;
            }
            
            return Constants.IfUserWantContinue;
        }
        
        /// <summary>
        /// Method used for confirm chosen action by Contractor.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="choosenAction"></param>
        /// <returns></returns>
        public static bool CompleteActionForContractor( User user, char choosenAction)
        {
            Contractor contractor = (Contractor) user;    
            
            ShowOffers showOffers = MainMenuHelper.ShowWorkOffers;
            
            switch (choosenAction)
            {
                case '1':
                {
                    showOffers();
                }
                    break;
                
                case '2':
                {
                    Console.WriteLine("Please, enter work offer name:");
                    string enteredWorkOfferName = Console.ReadLine();
                    
                    var workOffer = WorkOffersStorage.GetWorkOffer(enteredWorkOfferName);
                    
                    contractor.CreateApplicationToWorkOffer(workOffer);
                    
                }
                    break;
                
                case '3':
                {
                    var workOffers = WorkOffersStorage.GetWorkOffers(contractor);

                    foreach (WorkOffer offer in workOffers)
                    {
                        offer.ShowWorkOfferInformation();
                    }
                }
                    break;
                
                case '4':
                {
                    Console.WriteLine("Please, enter work offer name:");
                    string enteredWorkOfferName = Console.ReadLine();
                    
                    var workOffer = WorkOffersStorage.GetWorkOffer(enteredWorkOfferName);
                    
                    contractor.CheckUpConstructionWork(workOffer);
                    
                }
                    break;
                
                case '5':
                {
                    Authentication.LogOut();
                    return Constants.IfUserWantLogOut;
                }
            }
            
            return Constants.IfUserWantContinue;
        }
    }
}