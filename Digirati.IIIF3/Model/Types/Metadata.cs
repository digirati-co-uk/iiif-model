using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digirati.IIIF3.Model.JSONLD;

namespace Digirati.IIIF3.Model.Types
{
    public class Metadata
    {
        public JSONLDString Label { get; set; }

        public JSONLDString Value { get; set; }
    }
}
