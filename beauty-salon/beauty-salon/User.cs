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

        private UserRole GetRole(string role)
        {
            switch (role)
            {
                case "0":
                    return UserRole.Guest;
                case "1":
                    return UserRole.Client;
                case "2":
                    return UserRole.User;
                case "3":
                    return UserRole.Admin;
                default:
                    return UserRole.Guest;
            }
        }

        public enum UserRole { Guest, Client, User, Admin };

    }
}
