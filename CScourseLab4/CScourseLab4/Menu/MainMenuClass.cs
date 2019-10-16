using System;

namespace CScourseLab4
{
    public class MainMenuClass
    {
        public static void CompleteActionForCustomer( User user, char choosenAction)
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
                        Console.WriteLine($"{workOffer};");
                    }
                }
                    break;
                
                case '3':
                {
                    Console.WriteLine("Please, enter work offer name:");
                    string enteredWorkOfferName = Console.ReadLine();
                    
                    var workOffer = WorkOffersStorage.GetWorkOffer(enteredWorkOfferName);
                    
                    Console.WriteLine($"Selected work offer:\n" +
                                      $"{workOffer}");
                    
                    Console.WriteLine("Please, choose action:\n" +
                                      "1.Show applications to work offer." +
                                      "2.Confirm application.");
                    
                    char chosenActionForWorkOffer = Char.Parse(Console.ReadLine());

                    MainMenuHelper.PerformApplicationAction(workOffer, chosenActionForWorkOffer, customer);
                    
                }
                    break;
                
            }
        }
        
        public static void CompleteActionForAdministrator( User user, char choosenAction)
        {
            
        }
        
        public static void CompleteActionForContractor( User user, char choosenAction)
        {
            
        }
    }
}