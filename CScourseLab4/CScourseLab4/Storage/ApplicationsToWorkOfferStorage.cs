using System.Collections.Generic;

namespace CScourseLab4
{
    public static class ApplicationsToWorkOfferStorage
    {
        public static List<ApplicationToWorkOffer> _ApplicationToWorkOffers = new List<ApplicationToWorkOffer>();

        public static List<ApplicationToWorkOffer> GetApplicationsToWorkOffer(WorkOffer workOffer)
        {
            return _ApplicationToWorkOffers.FindAll(x => x._WorkOffer == workOffer);
        }
        
        public static ApplicationToWorkOffer GetApplicationToWorkOffer(WorkOffer workOffer, string contractorName)
        {
            return _ApplicationToWorkOffers.Find(x =>
                (x._WorkOffer == workOffer && x._Contractor.ToString() == contractorName));
        }
    }
}