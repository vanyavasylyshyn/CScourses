using System;
using System.Linq;

namespace CScourseLab4
{
    /// <summary>
    /// Class used for authentication user in system.
    /// </summary>
    public class Authentication
    {
        /// <summary>
        /// Method used for registration users in system.
        /// </summary>
        public static void Registration()
        {
            try
            {
                Console.WriteLine("Choose account type: \n" +
                                  "1.Customer.\n" +
                                  "2.Contractor.\n" +
                                  "3.Administrator.");
            
                char choosenAction = Char.Parse(Console.ReadLine());

                switch (choosenAction)
                {
                    case '1':
                    {
                        Customer customer = new Customer();
                        AuthenticationHelper.FillUserInformation(customer);
                        UserStorage._Users.Add(customer);
                    }
                        break;
                
                    case '2':
                    {
                        Contractor contractor = new Contractor();
                        AuthenticationHelper.FillUserInformation(contractor);
                    
                        Console.WriteLine("Please, enter qualification:");
                        contractor._Qualification = Console.ReadLine();
            
                        Console.WriteLine("Please, enter experience:");
                        contractor._Experience = Console.ReadLine();
                    
                        UserStorage._Users.Add(contractor);
                    }
                        break;
                
                    case '3':
                    {
                        Administrator administrator = new Administrator();
                        AuthenticationHelper.FillUserInformation(administrator);
                        UserStorage._Users.Add(administrator);
                    }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        
        /// <summary>
        /// Method used for log in user in system.
        /// </summary>
        /// <returns>Logged in user object</returns>
        public static User Authorization()
        {
            try
            {
                Console.WriteLine("Please, enter login:");
                string enteredLogin = Console.ReadLine();
            
                Console.WriteLine("Please, enter password:");
                string enteredPassword = Console.ReadLine();

                return AuthenticationHelper.AuthorizateUser(enteredLogin, enteredPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void LogOut()
        {
            Console.WriteLine("Log out successful. Bye bye!");
        }
    }
}