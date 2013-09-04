using System;

namespace beauty_salon
{
    public class Service
    {
        public Service(int id ,string name, Decimal cost)
        {
            Id = id;
            Name = name;
            Cost = cost;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Cost { get; set; }

        public override string ToString()
        {
            return Name + ": " + Cost + "p.";
        }
    }
}
