

namespace SuperFlightsApp.Model
{
    public class User : Entity<long>
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private byte[] _salt;
        private byte[] _profilePic;

        public User(long id,
                    string firstName,
                    string lastName,
                    string email,
                    string password,
                    byte[] salt,
                    byte[] profilePic) : base(id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
            _salt = salt;
            _profilePic = profilePic;
        }

        public string FirstName
        { 
            get { return _firstName; } 
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public byte[] Salt
        {
            get { return _salt; }
            set { _salt = value; }
        }

        public byte[] ProfilePic
        { 
            get { return _profilePic; }
            set { _profilePic = value; }
        }
    }
}
