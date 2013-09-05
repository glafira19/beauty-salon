using System;

namespace beauty_salon
{
    public class Service
    {
        public Service(Guid guid, string name, Decimal cost)
        {
            Guid = guid;
            Name = name;
            Cost = cost;
        }

        public Service()
        {
            Guid = Guid.NewGuid();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public Decimal Cost { get; set; }

        public override string ToString()
        {
            return Name + ": " + Cost + "p.";
        }
    }
}
