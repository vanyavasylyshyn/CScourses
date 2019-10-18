using System;

namespace CScourseLab4
{
    /// <summary>
    /// This class used for showing interface for user.
    /// </summary>
    public class Interface
    {
        /// <summary>
        /// Method used for showing first menu for user.
        /// </summary>
        /// <returns>Logged in user object</returns>
        public static User ChooseFirstAction()
        {
            User user = null;
            while (true)
            {
                
                Console.WriteLine("Please, choose action: \n" +
                                  "1.Registration.\n" +
                                  "2.Log in.\n" +
                                  "3.Finish program.");
                char choosenAction = Char.Parse(Console.ReadLine());
                
                switch (choosenAction)
                {
                    case '1':
                    {
                        Authentication.Registration();
                    }
                        break;
                    
                    case '2':
                    {
                        user = Authentication.Authorization();
                    }
                        break;
                    
                    case '3':
                    {
                        System.Environment.Exit(0);
                    }
                        break;
                }

                if (choosenAction == '2')
                {
                    break;
                }
            }

            return user;
        }

        /// <summary>
        /// Method used for showing main many for every type of user.
        /// </summary>
        /// <param name="user"></param>
        public static void MainMenu(User user)
        {
            Console.WriteLine($"Hi, {user._Name} {user._Surname}, please choose some action: ");
            while (true)
            {
                if (user is Customer)
                {
                    Console.WriteLine("1.Create work offer.\n" +
                                      "2.Show my work offers.\n" +
                                      "3.Choose work offer.\n" +
                                      "4.Log out.");

                    char choosenAction = Char.Parse(Console.ReadLine());
                
                    bool userStatus = MainMenuInterface.CompleteActionForCustomer(user, choosenAction);
                    if (!userStatus)
                    {
                        break;
                    }
                    
                }
                else if (user is Administrator)
                {
                    Console.WriteLine("1.Show unverified contractors.\n" +
                                      "2.Verify contractor.\n" +
                                      "3.Show work offers.\n" +
                                      "4.Close work offer.\n" +
                                      "5.Log out.");
                    
                    char choosenAction = Char.Parse(Console.ReadLine());
                
                    bool userStatus = MainMenuInterface.CompleteActionForAdministrator(user, choosenAction);
                    if (!userStatus)
                    {
                        break;
                    }
                }
                else if(user is Contractor)
                {
                    Console.WriteLine("1.Show open work offers\n" +
                                      "2.Create application to work offer\n" +
                                      "3.Show my active work offers.\n" +
                                      "4.Check up construction work\n" +
                                      "5.Log out.");
                    
                    char choosenAction = Char.Parse(Console.ReadLine());
                
                    bool userStatus = MainMenuInterface.CompleteActionForContractor(user, choosenAction);
                    if (!userStatus)
                    {
                        break;
                    }
                }   
            }
        }
    }
}