using Digirati.IIIF.Model;
using System.Collections.Generic;

namespace Digirati.IIIF.Serialisation
{
    public class ServiceEqualityComparer : IEqualityComparer<IService>
    {
        public bool Equals(IService s1, IService s2)
        {
            return s1.Id == s2.Id;
        }
        
        public int GetHashCode(IService s)
        {
            return s.Id.GetHashCode();
        }

    }
}
