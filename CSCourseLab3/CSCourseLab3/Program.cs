using System;
using CSCourseLab3.Forms;

namespace CSCourseLab3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Shapes choosenForm = UserInterface.chooseFormToGenerateElements();
                UserInterface.chooseWayOfGeneratingElements(choosenForm);
                UserInterface.chooseAction(choosenForm);   
            }
        }
    }
}