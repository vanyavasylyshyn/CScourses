namespace CScourseLab4
{
    /// <summary>
    /// This class used for creation work offers by customers.
    /// </summary>
    public class WorkOffer
    {
        private string _name;
        private string _shortDescription;
        private int _estimate;
        private WorkOfferStatus _workOfferStatus;
        private Administrator _administrator;
        private Customer _customer;
        private City _city;
        private ApplicationToWorkOffer[] _applicationToWorkOffe;
        private string _street;
        private byte _houseNumber;
    }
}