using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace beauty_salon
{
    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public List<ClientService> Services { get; set; }

        public User(string name)
        {
            Services = new List<ClientService>();
            Role = UserRole.Guest;
            Name = name;
        }

        public User(string name, string login, string password, string role)
        {
            Services = new List<ClientService>();
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

        public void AddService(Service selectedService, DateTime time)
        {
            Services.Add(new ClientService(selectedService, time));
        }

        public void SaveServices()
        {
            XmlWorker.SaveClientServices(Services, Login);
        }

        public void RemoveService(ClientService selectedItem)
        {
            Services.Remove(selectedItem);
        }

        public override string ToString()
        {
            return Name + " (" + Login + ")";
        }
    }
}
