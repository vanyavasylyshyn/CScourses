using System;
using CSCourseLab3.Forms;

namespace CSCourseLab3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Shapes choosenForm = UserInterface.chooseFormToGenerateElements(); 
            UserInterface.chooseWayOfGeneratingElements(choosenForm); 
            UserInterface.chooseAction(choosenForm);
        }
    }
}