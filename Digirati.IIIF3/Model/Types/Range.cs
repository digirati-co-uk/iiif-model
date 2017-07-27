using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digirati.IIIF3.Model.Types
{
    public class Range
    {
        public string ViewingDirection { get; set; }

        public string StartCanvas { get; set; }

        // TODO - this becomes a serialisation decision
        // in P3 ranges are nested objects, not flattened out.
        // URIs of ranges
        public string[] Ranges { get; set; }

        // URIs of canvases
        public string[] Canvases { get; set; }
    }
}
