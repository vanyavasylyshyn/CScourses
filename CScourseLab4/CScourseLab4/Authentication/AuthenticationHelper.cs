using System;

namespace CScourseLab4
{
    public static class AuthenticationHelper
    {
        /// <summary>
        /// Method used for filling user object by entered information.
        /// </summary>
        /// <param name="user"></param>
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

        /// <summary>
        /// Method used for checking login and password.
        /// </summary>
        /// <param name="enteredLogin"></param>
        /// <param name="enteredPassword"></param>
        /// <returns>Logged in user object</returns>
        public static User AuthorizateUser( string enteredLogin, string enteredPassword)
        {
            User user = null;

            if (UserStorage._Users.Exists(x => (x._Login == enteredLogin &&
                                              x._Password == enteredPassword)))
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