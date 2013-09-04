using System;

namespace beauty_salon
{
    public class ClientService
    {
        public ClientService(Service service, DateTime dateTime)
        {
            Service = service;
            Time = dateTime;
        }

        public Service Service { get; set; }
        public DateTime Time { get; set; }

        public override string ToString()
        {
            return Service.ToString() + " - " + Time.ToString();
        }
    }
}
