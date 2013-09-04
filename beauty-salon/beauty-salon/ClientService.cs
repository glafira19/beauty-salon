using System;

namespace beauty_salon
{
    public class ClientService
    {
        public ClientService(Service service, DateTime date)
        {
            Service = service;
            Date = date;
        }

        public Service Service { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Date.ToString("MM.dd.yyyy hh:mm") + " - " +Service;
        }
    }
}
