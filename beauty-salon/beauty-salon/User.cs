namespace beauty_salon
{
    public class User
    {
        private string _name;
        private Role _role;

        public User(string name)
        {
            _role = Role.Guest;
            _name = name;
        }

        public enum Role { Guest, User, Admin };

        public string GetName()
        {
            return _name;
        }

        public void SetRole(Role role)
        {
            _role = role;
        }
    }
}
