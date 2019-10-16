using System;
using System.Linq;

namespace CScourseLab4
{
    public class Customer : User
    {
        public void CreateWorkOffer()
        {
            WorkOffer workOffer = new WorkOffer();
            
            Console.WriteLine("Please, enter offer name:");
            workOffer._Name = Console.ReadLine();
            
            Console.WriteLine("Please, enter short description:");
            workOffer._ShortDecription = Console.ReadLine();
            
            Console.WriteLine("Please, enter estimate:");
            workOffer._Estimate = Int32.Parse(Console.ReadLine());

            workOffer._Administrator = (Administrator)UserStorage._Users.Find(_workOffer => _workOffer == null);

            workOffer._Customer = this;
            
        }

        public void ConfirmApplicationToWorkOffer(WorkOffer workOffer, string contractorName)
        {
            ApplicationsToWorkOfferStorage.GetApplicationToWorkOffer(workOffer, contractorName);
        }
    }
}