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
            var attributeId = e.Attribute("Guid");
            var attributeName = e.Attribute("Name");
            var attributeCost = e.Attribute("Cost");
            if ((attributeName != null)
                && (attributeCost != null))
            {
                var guid = Guid.Parse(attributeId.Value);
                var name = attributeName.Value;
                var cost = Convert.ToDecimal(attributeCost.Value);
                return new Service(guid, name, cost);
            }
            throw new Exception("Error in settings file. Corrupt user information");
        }

        public static List<ClientService> GetServices(string login)
        {
            var allServices = GetServices();
            var xDocument = XDocument.Load(CLIENT_SERVICES_FILE);
            var clientServices = new List<ClientService>();
            if (xDocument.Root != null)
            {
                var client =
                    xDocument.Root.Elements().FirstOrDefault(
                        e => e.Name == "Client" && e.Attribute("Login").Value == login);
                if (client != null)
                {
                    var services = client.Elements().FirstOrDefault(e => e.Name == "Services");
                    if (services != null)
                    {
                        foreach (var service in services.Elements())
                        {
                            if (service.Name == "Service")
                            {
                                var attributeGuid = service.Attribute("Guid");
                                var attributeDate = service.Attribute("Date");
                                if (attributeGuid != null && attributeDate != null)
                                {
                                    var guid = Guid.Parse(attributeGuid.Value);
                                    var date = Convert.ToDateTime(attributeDate.Value);
                                    var ser = allServices.First(s => s.Guid == guid);
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

        public static void SaveClientServices(List<ClientService> services, string login)
        {
            var xDocument = XDocument.Load(CLIENT_SERVICES_FILE);
            if (xDocument.Root != null)
            {
                var client =
                    xDocument.Root.Elements().FirstOrDefault(
                        e => e.Name == "Client" && e.Attribute("Login").Value == login);
                if (client != null)
                {
                    client.Elements().Where(e => e.Name == "Services").Remove();
                    var servicesElement = new XElement("Services");
                    client.Add(servicesElement);
                    servicesElement = client.Elements().FirstOrDefault(e => e.Name == "Services");
                    foreach (var service in services)
                    {
                        var termElem = new XElement("Service");
                        termElem.Add(new XAttribute("Guid", service.Service.Guid));
                        termElem.Add(new XAttribute("Date", service.Date));
                        servicesElement.Add(termElem);
                    }
                }
            }
            xDocument.Save(CLIENT_SERVICES_FILE);
        }

        public static List<User> GetClients()
        {
            var users = GetUsers();
            var clients = users.Where(u => u.Role == User.UserRole.Client).ToList();
            foreach (var client in clients)
            {
                var clientServices = GetServices(client.Login);
                client.Services = clientServices;
            }
            return clients;
        }

        public static void AddService(Service service, bool isUpdate)
        {
            var xDocument = XDocument.Load(SERVICES_FILE);
            if (xDocument.Root != null)
            {
                if (isUpdate)
                {
                    xDocument.Root.Elements().Where(e => e.Attribute("Guid").Value == service.Guid.ToString()).Remove();
                }
                var elem = new XElement("Service");
                elem.Add(new XAttribute("Guid", service.Guid));
                elem.Add(new XAttribute("Name", service.Name));
                elem.Add(new XAttribute("Cost", service.Cost));
                xDocument.Root.Add(elem);
            }
            xDocument.Save(SERVICES_FILE);
        }

        public static void RemoveService(Service service)
        {
            var xDocument = XDocument.Load(SERVICES_FILE);
            if (xDocument.Root != null)
            {
                xDocument.Root.Elements().Where(e => e.Attribute("Guid").Value == service.Guid.ToString()).Remove();
            }
            xDocument.Save(SERVICES_FILE);
            RemoveClientService(service);
        }

        private static void RemoveClientService(Service removingService)
        {
            var xDocument = XDocument.Load(CLIENT_SERVICES_FILE);
            if (xDocument.Root != null)
            {
                var clients = xDocument.Root.Elements();
                foreach (var client in clients)
                {
                    var services = client.Elements().FirstOrDefault(e => e.Name == "Services");
                    if (services != null)
                    {
                        services.Elements().Where(e => e.Attribute("Guid").Value == removingService.Guid.ToString()).Remove();
                    }
                }
            }
            xDocument.Save(CLIENT_SERVICES_FILE);
        }
    }
}
