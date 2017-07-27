using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digirati.IIIF3.Model.JSONLD;

namespace Digirati.IIIF3.Model.Types
{
    public class Resource : ExternalResource
    {
        public string Format { get; set; }
    }
}
