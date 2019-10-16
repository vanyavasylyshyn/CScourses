using System;
using System.Linq;

namespace CScourseLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = Interface.ChooseFirstAction();
            Interface.MainMenu(user);
            
        }
    }
}