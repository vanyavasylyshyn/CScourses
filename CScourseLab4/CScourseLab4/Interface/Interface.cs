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
    }
}