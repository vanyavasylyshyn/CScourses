using System.Collections.Generic;

namespace CScourseLab4
{
    public static class WorkOffersStorage
    {
        public static List<WorkOffer> _WorkOffers = new List<WorkOffer>();
        
        public static List<WorkOffer> GetWorkOffers(Customer customer)
        {
            return _WorkOffers.FindAll(x => x._Customer == customer);
        }
        
        public static WorkOffer GetWorkOffer(string enteredName)
        {
            return _WorkOffers.Find(x => x._Name == enteredName);
        }
        
        public static WorkOffer GetWorkOffer(WorkOffer workOffer)
        {
            return _WorkOffers.Find(x => x._Name == workOffer._Name);
        }
    }
}