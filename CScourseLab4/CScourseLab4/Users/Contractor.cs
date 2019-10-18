using System;

namespace CScourseLab4
{
    public class Contractor : User
    {
        private bool _verifycation = false;

        public bool _Veryfycation
        {
            get => _verifycation;
        }
        
        private string _qualification;
        public string _Qualification
        {
            set => _qualification = value;
        }
        
        private string _experience;
        public string _Experience
        {
            set => _experience = value;
        }

        public void VerifyContractor()
        {
            _verifycation = true;
        }

        public void CreateApplicationToWorkOffer(WorkOffer workOffer)
        {
            ApplicationToWorkOffer applicationToWorkOffer = new ApplicationToWorkOffer();
            
            Console.WriteLine("Please, enter payment proposal:");
            int paymnetProposal = Int32.Parse(Console.ReadLine());

            applicationToWorkOffer.Payment = paymnetProposal;

            applicationToWorkOffer._Contractor = this;
            
            workOffer._ApplicationToWorkOffer = applicationToWorkOffer;
        }

        public void CheckUpConstructionWork(WorkOffer workOffer)
        {
            var constuctionWorks = workOffer._ConstructionWorks;

            foreach (var work in constuctionWorks)
            {
                Console.WriteLine($"{work};");
            }
            
            Console.WriteLine("Please, enter work specification:");
            string specification = Console.ReadLine();

            ConstructionWork findedContructionWork = constuctionWorks.Find(x => x._Specification == specification);
            
            findedContructionWork.CheckUp();
        }
        
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Veryfication: {_verifycation};\n" +
                              $"Qualication: {_qualification};\n" +
                              $"Experience: {_experience};");
        }
    }
}