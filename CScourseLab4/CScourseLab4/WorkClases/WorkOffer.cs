using System;
using System.Collections.Generic;

namespace CScourseLab4
{
    /// <summary>
    /// This class used for creation work offers by customers.
    /// </summary>
    public class WorkOffer
    {
        private List<ApplicationToWorkOffer> _applicationToWorkOffers = new List<ApplicationToWorkOffer>();
        public List<ApplicationToWorkOffer> _ApplicationToWorkOffers
        {
            get => _applicationToWorkOffers;
        }

        public ApplicationToWorkOffer _ApplicationToWorkOffer
        {
            set => _applicationToWorkOffers.Add(value);
        }
        
        private List<ConstructionWork> _constructionWorks = new List<ConstructionWork>();

        public List<ConstructionWork> _ConstructionWorks
        {
            get => _constructionWorks;
        }
        public ConstructionWork _ConstructionWork
        {
            set
            {
                _constructionWorks.Add(value);
            }
        }
        
        private string _name;
        public string _Name
        {
            get => _name;
            set => _name = value;
        }
        
        private string _shortDescription;
        public string _ShortDecription
        {
            set => _shortDescription = value;
        }
        
        private int _estimate;
        public int _Estimate
        {
            set => _estimate = value;
        }
        
        private Administrator _administrator;
        public Administrator _Administrator
        {
            set => _administrator = value;
        }
        
        private Customer _customer;
        public Customer _Customer
        {
            get => _customer;
            set => _customer = value;
        }
        
        
        private Contractor _currentContractor;
        public Contractor _CurrentContractor
        {
            get => _currentContractor;
            set => _currentContractor = value;
        }
        
        private WorkOfferStatus _workOfferStatus = WorkOfferStatus.Opened;
        public WorkOfferStatus _WorkOfferStatus
        {
            get => _workOfferStatus;
            set => _workOfferStatus = value;
        }

        public void CloseWorkOffer()
        {
            if (_workOfferStatus == WorkOfferStatus.Opened)
            {
                _workOfferStatus = WorkOfferStatus.Closed;
                _administrator = null;
                
                Console.WriteLine("Offer closed.");
            }
            else
            {
                Console.WriteLine("Offer already closed.");
            }
        }

        public ApplicationToWorkOffer GetApplicationToWorkOfferByNameAndSurname(string contractorName, string contractorSurname)
        {
            return _applicationToWorkOffers.Find(x =>
                x._Contractor._Name == contractorName && x._Contractor._Surname == contractorSurname);
        }

        public void ShowWorkOfferInformation()
        {
            Console.WriteLine("Information about work offer:\n" +
                              $"Name: {_name};\n" +
                              $"Short description: {_shortDescription};\n" +
                              $"Estimate: {_estimate};\n" +
                              $"Work offer status: {_workOfferStatus};\n" +
                              $"Current contractor: {_currentContractor._Name} {_currentContractor._Surname};\n" +
                              $"Customer: {_customer._Name} {_customer._Surname};\n" +
                              $"Administrator: {_administrator._Name} {_administrator._Surname};\n" +
                              "Construction works: ");
            
            _constructionWorks.ForEach(work => work.ShowWorkInformation());
        }
    }
}