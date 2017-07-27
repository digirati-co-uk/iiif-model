using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digirati.IIIF3.Model.JSONLD;

namespace Digirati.IIIF3.Model.Types
{
    public abstract class ExternalResource : JSONLDBase
    {
        public List<JSONLDString> Label { get; set; }
        
        public List<Profile> Profile { get; set; }

        public List<Service> Service { get; set; }
    }
}
