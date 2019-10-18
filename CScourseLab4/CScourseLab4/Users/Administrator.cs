namespace CScourseLab4
{
    public class Administrator : User
    {
        private WorkOffer _workOffer = null;

        public WorkOffer _WorkOffer
        {
            set => _workOffer = value;
            get => _workOffer;
        }
    }
}