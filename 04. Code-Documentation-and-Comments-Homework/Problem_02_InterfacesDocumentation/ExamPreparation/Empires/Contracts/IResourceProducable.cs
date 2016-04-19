using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Contracts
{
    /// <summary>
    /// Can create resources within a given time.
    /// </summary>
    public interface IResourceProducable
    {
        bool CanProduceResource { get; set; }

        IResource ProduceResource();
    }
}
