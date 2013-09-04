using System;
using System.Xml.Linq;

namespace beauty_salon
{
    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }

        public User(string name)
        {
            Role = UserRole.Guest;
            Name = name;
        }

        public User(string name, string login, string password, string role)
        {
            Role = GetRole(role);
            Name = name;
            Login = login;
            Password = password;
        }

        public User(XElement e)
        {
            var attributeName = e.Attribute("Name");
            var attributeLogin = e.Attribute("Login");
            var attributePassword = e.Attribute("Password");
            var attributeRole = e.Attribute("Role");
            if ((attributeName != null)
                && (attributeLogin != null)
                && (attributePassword != null)
                && (attributeRole != null))
            {
                Name = attributeName.Value;
                Login = attributeLogin.Value;
                Password = attributePassword.Value;
                Role = GetRole(attributeRole.Value);
            }
            else
            {
                throw new Exception("Error in settings file. Corrupt user information");
            }
        }

        private UserRole GetRole(string role)
        {
            switch (role)
            {
                case "0":
                    return UserRole.Guest;
                case "1":
                    return UserRole.User;
                case "2":
                    return UserRole.Admin;
                default:
                    return UserRole.Guest;
            }
        }

        public enum UserRole { Guest, User, Admin };

    }
}
