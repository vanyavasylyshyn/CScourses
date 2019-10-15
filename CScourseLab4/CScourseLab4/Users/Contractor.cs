namespace CScourseLab4
{
    public class Contractor : User
    {
        private bool _verifycation = false;
        
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
    }
}