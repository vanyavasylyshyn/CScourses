using System.Collections.Generic;

namespace CScourseLab4
{
    /// <summary>
    /// Class used for saving users in system.
    /// </summary>
    public static class UserStorage
    {
        public static List<User> _Users = new List<User>();

        public static List<Contractor> GetUnverifyedContractors()
        {
            List<User> findedUsers = _Users.FindAll(x => x.GetType() == typeof(Contractor));

            List<Contractor> findedContractors = new List<Contractor>(); 
            foreach (User user in findedUsers)
            {
                Contractor contractor = (Contractor) user;
                
                if (contractor._Veryfycation == false)
                {
                    findedContractors.Add(contractor);
                }
            }

            return findedContractors;
        }

        public static Contractor GetUserByNameAndSurname(string name, string surname)
        {
            return (Contractor)_Users.Find(x => (x.GetType() == typeof(Contractor)) && 
                                                x._Name == name && x._Surname == surname);
        }
    }
}