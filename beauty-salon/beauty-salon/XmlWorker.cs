using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace beauty_salon
{
    public class XmlWorker
    {
        private const string SETTINGS_FILE = ".\\Data\\Settings.Xml";
        private const string SERVICES_FILE = ".\\Data\\Services.Xml";
        private const string CLIENT_SERVICES_FILE = ".\\Data\\Clients.Xml";

        public static List<User> GetUsers()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            var list = new List<User>();
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "Users")
                    {
                        list.AddRange(from e in xElement.Elements()
                                      where e.Name == "User"
                                      select GetUser(e));
                    }
                }
            return list;
        }


        public static User GetUser(XElement e)
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
                var name = attributeName.Value;
                var login = attributeLogin.Value;
                var password = attributePassword.Value;
                var role = attributeRole.Value;
                return new User(name, login, password, role);
            }
            throw new Exception("Error in settings file. Corrupt user information");
        }

        public static string GetLastLogin()
        {
            var xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements().Where(xElement => xElement.Name == "LastLogin"))
                {
                    return xElement.Value;
                }
            return "";
        }

        public static List<Service> GetServices()
        {
            var xDocument = XDocument.Load(SERVICES_FILE);
            var list = new List<Service>();
            if (xDocument.Root != null)
            {
                list.AddRange(from e in xDocument.Root.Elements()
                              where e.Name == "Service"
                              select GetService(e));
            }
            return list;
        }

        private static Service GetService(XElement e)
        {
            var attributeId = e.Attribute("Id");
            var attributeName = e.Attribute("Name");
            var attributeCost = e.Attribute("Cost");
            if ((attributeName != null)
                && (attributeCost != null))
            {
                var id = Convert.ToInt32(attributeId.Value);
                var name = attributeName.Value;
                var cost = Convert.ToDecimal(attributeCost.Value);
                return new Service(id, name, cost);
            }
            throw new Exception("Error in settings file. Corrupt user information");
        }

        public static List<ClientService> GetServices(User selectedClient)
        {
            var allServices = GetServices();
            var xDocument = XDocument.Load(CLIENT_SERVICES_FILE);
            var clientServices = new List<ClientService>();
            if (xDocument.Root != null)
            {
                var client = xDocument.Root.Elements().FirstOrDefault(e => e.Name == "Client" && e.Attribute("Login").Value == selectedClient.Login);
                if (client != null)
                {
                    var services = client.Elements().FirstOrDefault(e => e.Name == "Services");
                    if (services != null)
                    {
                        foreach (var service in services.Elements())
                        {
                            if (service.Name == "Service")
                            {
                                var attributeId = service.Attribute("Id");
                                var attributeDate = service.Attribute("Date");
                                if (attributeId != null && attributeDate != null)
                                {
                                    var id = Convert.ToInt32(attributeId.Value);
                                    var date = Convert.ToDateTime(attributeDate.Value);
                                    var ser = allServices.First(s => s.Id == id);
                                    var a = new ClientService(ser, date);
                                    clientServices.Add(a);
                                }
                            }
                        }
                    }
                }
            }
            return clientServices;
        }
    }
}
