using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Models;

namespace Empires.Factories
{
    /// <summary>
    /// Factory class for creating resources.
    /// </summary>
    public class ResourceFactory : IResourceFactory
    {
        /// <summary>
        /// Creates quantity of the requared resource.
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="resourceQuantity"></param>
        /// <returns></returns>
        public IResource CreateResource(Enums.ResourceType resourceType, int resourceQuantity)
        {
            return new Resource(resourceType,resourceQuantity);
        }
    }
}
