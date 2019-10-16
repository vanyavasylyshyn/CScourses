using System;

namespace CScourseLab4
{
    public class Interface
    {
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

        public static void MainMenu(User user)
        {
            Console.WriteLine($"Hi, {user._Name} {user._Surname}, please choose some action: ");
            
            if (user.GetType() == typeof(Customer))
            {
                Console.WriteLine("1.Create work offer.\n" +
                                  "2.Show my work offers.\n" +
                                  "3.Choose work offer.\n" +
                                  "4.Log out.");

                char choosenAction = Char.Parse(Console.ReadLine());
                
                MainMenuClass.CompleteActionForCustomer(user, choosenAction);
            }
            else if (user.GetType() == typeof(Administrator))
            {
                //TODO menu
                char choosenAction = Char.Parse(Console.ReadLine());
                
                MainMenuClass.CompleteActionForAdministrator(user, choosenAction);
            }
            else if(user.GetType() == typeof(Contractor))
            {
                //TODO menu
                char choosenAction = Char.Parse(Console.ReadLine());
                
                MainMenuClass.CompleteActionForContractor(user, choosenAction);
            }
        }
    }
}