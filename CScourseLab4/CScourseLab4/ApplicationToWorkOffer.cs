namespace CScourseLab4
{
    /// <summary>
    /// This class is using for applications to customer offer by contractors.
    /// </summary>
    public class ApplicationToWorkOffer
    {
        private int _payment;
        private bool _status;

        private Contractor _contractor;
        public Contractor _Contractor
        {
            get => _contractor;
        }
        
        private WorkOffer _workOffer;
        public WorkOffer _WorkOffer
        {
            get => _workOffer;
        }
    }
}