using System;

namespace CScourseLab4
{
    /// <summary>
    /// This class is using for applications to customer offer by contractors.
    /// </summary>
    public class ApplicationToWorkOffer
    {
        private int _payment;

        public int Payment
        {
            set => _payment = value;
        }

        private Contractor _contractor;

        public Contractor _Contractor
        {
            get => _contractor;
            set => _contractor = value;
        }

        public void ShowApplicationInformation()
        {
            Console.WriteLine("Information about application to work offer:\n" +
                              $"Payment: {_payment};\n" +
                              $"Contractor: {_contractor._Name} {_contractor._Surname};");
        }
}
}