namespace CScourseLab4
{
    public abstract class User
    {
        protected string _name;
        public string _Name
        {
            set => _name = value;
        }
        
        protected string _surname;
        public string _Surname
        {
            set => _surname = value;
        }
        
        protected string _phoneNumber;
        public string _PhoneNumber
        {
            set => _phoneNumber = value;
        }
        
        protected string _email;
        public string _Email
        {
            set => _email = value;
        }
        
        protected string _login;
        public string _Login
        {
            get => _login;
            set => _login = value;
        }
        
        protected string _password;
        public string _Password
        {
            get => _password;
            set => _password = value;
        }
        
        protected AccessRights _accessRights;
        public AccessRights _AccessRights
        {
            set => _accessRights = value;
        }
    }
}