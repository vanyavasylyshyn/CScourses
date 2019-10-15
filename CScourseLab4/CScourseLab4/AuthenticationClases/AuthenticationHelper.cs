using System;

namespace CScourseLab4
{
    public static class AuthenticationHelper
    {
        public static void FillUserInformation(User user)
        {
            Console.WriteLine("Please, enter name:");
            user._Name = Console.ReadLine();
            
            Console.WriteLine("Please, enter surname:");
            user._Surname = Console.ReadLine();
            
            Console.WriteLine("Please, enter phone number:");
            user._PhoneNumber = Console.ReadLine();
            
            Console.WriteLine("Please, enter email:");
            user._Email = Console.ReadLine();
            
            Console.WriteLine("Please, enter login:");
            user._Login = Console.ReadLine();
            
            Console.WriteLine("Please, enter password:");
            user._Password = Console.ReadLine();

            if (user.GetType() == typeof(Administrator))
            {
                user._AccessRights = AccessRights.Admin;
            }
            else
            {
                user._AccessRights = AccessRights.User;
            }
        }

        public static User AuthorizateUser( string enteredLogin, string enteredPassword)
        {
            User user = null;
            
            if (UserStorage._Users.Find(x => (x._Login == enteredLogin &&
                                              x._Password == enteredPassword)).GetType() == typeof(Contractor))
            {
                user = UserStorage._Users.Find(x => (x._Login == enteredLogin &&
                                                          x._Password == enteredPassword));
                
                Console.WriteLine("Log in successful!!");
            }
            else if(UserStorage._Users.Find(x => (x._Login == enteredLogin &&
                                                  x._Password == enteredPassword)).GetType() == typeof(Administrator))
            {
                user = UserStorage._Users.Find(x => (x._Login == enteredLogin &&
                                                          x._Password == enteredPassword));
                
                Console.WriteLine("Log in successful!!");
            }
            else if (UserStorage._Users.Find(x => (x._Login == enteredLogin &&
                                                   x._Password == enteredPassword)).GetType() == typeof(Customer))
            {
                user = UserStorage._Users.Find(x => (x._Login == enteredLogin &&
                                                          x._Password == enteredPassword));
                
                Console.WriteLine("Log in successful!!");
            }
            else
            {
                Console.WriteLine("Sorry, your login or password is incorrect or user do not exist.");
            }

            return user;
        }
    }
}