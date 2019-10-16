using System.Collections.Generic;

namespace CScourseLab4
{
    /// <summary>
    /// This class used for creation work offers by customers.
    /// </summary>
    public class WorkOffer
    {
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
        
        
        private ApplicationToWorkOffer _currentContractor;

        public ApplicationToWorkOffer _CurrentContractor
        {
            set => _currentContractor = value;
        }
        
        private ConstructionWork[] _constructionWorks;
        private WorkOfferStatus _workOfferStatus = WorkOfferStatus.Opened;
    }
}