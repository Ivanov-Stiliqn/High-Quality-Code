using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;

namespace Empires.Contracts
{
    /// <summary>
    /// Can create resources by their types.
    /// </summary>
    public interface IResourceFactory
    {
        IResource CreateResource(ResourceType resourceType, int resourceQuantity);
    }
}
