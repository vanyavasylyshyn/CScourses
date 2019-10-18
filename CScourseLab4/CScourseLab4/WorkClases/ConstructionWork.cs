using System;

namespace CScourseLab4
{
    /// <summary>
    /// Class used for descriprion tasks in work offer.
    /// </summary>
    public class ConstructionWork
    {
        private bool _status = false;
        
        private int _amount;
        public int _Amount
        {
            set => _amount = value;
        }
        
        private string _specification;
        public string _Specification
        {
            get => _specification;
            set => _specification = value;
        }
        
        private string _description;
        public string _Description
        {
            set => _description = value;
        }

        public void CheckUp()
        {
            _status = true;
        }
        
        public void ShowWorkInformation()
        {
            Console.WriteLine("Information about work:\n" +
                              $"Specification: {_specification};\n" +
                              $"Amount: {_amount};\n" +
                              $"Description: {_description};");

        }
        
    }
}