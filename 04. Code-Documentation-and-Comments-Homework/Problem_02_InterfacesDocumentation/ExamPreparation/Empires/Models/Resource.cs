using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Enums;

namespace Empires.Models
{
    public class Resource : IResource
    {
        public Resource(ResourceType type, int quantity)
        {
            this.Type = type;
            this.Quantity = quantity;
        }

        public Enums.ResourceType Type { get; private set; }

        public int Quantity { get; private set; }
    }
}
