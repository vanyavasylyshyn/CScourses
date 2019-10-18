using System;
using System.Collections.Generic;
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


            if (UserStorage._Users.Exists(x => x is Administrator))
            {
                List<User> findedUsers = UserStorage._Users.FindAll(x => x is Administrator);

                foreach (User user in findedUsers)
                {
                    Administrator admin = (Administrator) user;
                    
                    if (admin._WorkOffer == null)
                    {
                        workOffer._Administrator = admin;
                        admin._WorkOffer = workOffer;
                        break;
                    }
                }
            }
            
            Console.WriteLine("Please, enter number of tasks:");
            byte numberOfTasks = byte.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfTasks; i++)
            {
                ConstructionWork task = new ConstructionWork();
                
                Console.WriteLine("Please, enter amount of work:");
                Int32 amount = Int32.Parse(Console.ReadLine());

                task._Amount = amount;
                
                Console.WriteLine("Please, enter specification:");
                string specification = Console.ReadLine();

                task._Specification = specification;
                
                Console.WriteLine("Please, enter description:");
                string description = Console.ReadLine();

                task._Description = description;

                workOffer._ConstructionWork = task;
            }

            workOffer._Customer = this;
            
            WorkOffersStorage._WorkOffers.Add(workOffer);
            
        }

        public void ConfirmApplicationToWorkOffer(WorkOffer workOffer, string contractorName, string contractorSurname)
        {
            ApplicationToWorkOffer findedApplication =
                workOffer.GetApplicationToWorkOfferByNameAndSurname(contractorName, contractorSurname);


            workOffer._WorkOfferStatus = WorkOfferStatus.InProgres;
            workOffer._CurrentContractor = findedApplication._Contractor;
        }
    }
}