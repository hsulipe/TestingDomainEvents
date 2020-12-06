using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingDomainEvents.Domain.Models
{
    public class Attributes
    {
        public Attributes()
        {
            
        }

        public Attributes(string playerId, string name, double value)
        {
            PlayerId = playerId;
            Name = name;
            Value = value;
        }
        public string PlayerId { get;  private set; }
        public string Name { get; private  set; }
        public double Value { get; private set; }
    }
}
