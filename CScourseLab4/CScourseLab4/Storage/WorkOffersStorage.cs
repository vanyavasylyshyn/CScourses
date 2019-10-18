using System.Collections.Generic;

namespace CScourseLab4
{
    /// <summary>
    /// Class used for saving work offers in system.
    /// </summary>
    public static class WorkOffersStorage
    {
        public static List<WorkOffer> _WorkOffers = new List<WorkOffer>();
        
        public static List<WorkOffer> GetWorkOffers(Customer customer)
        {
            return _WorkOffers.FindAll(x => x._Customer == customer);
        }
        
        public static List<WorkOffer> GetWorkOffers()
        {
            return _WorkOffers.FindAll(x => x._WorkOfferStatus == WorkOfferStatus.Opened);
        }
        
        public static List<WorkOffer> GetWorkOffers(Contractor contractor)
        {
            return _WorkOffers.FindAll(x => x._WorkOfferStatus == WorkOfferStatus.InProgres && x._CurrentContractor == contractor);
        }
        
        public static WorkOffer GetWorkOffer(string enteredName)
        {
            return _WorkOffers.Find(x => x._Name == enteredName);
        }
        
        public static WorkOffer GetWorkOffer(WorkOffer workOffer)
        {
            return _WorkOffers.Find(x => x._Name == workOffer._Name);
        }
        
        public static WorkOffer GetWorkOffer(Contractor contractor)
        {
            return _WorkOffers.Find(x => x._CurrentContractor == contractor);
        }
    }
}