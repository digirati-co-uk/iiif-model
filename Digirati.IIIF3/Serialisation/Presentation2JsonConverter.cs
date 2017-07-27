using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Digirati.IIIF3.Serialisation
{
    public class Presentation2JsonConverter : IPresentationJsonConverter
    {
        public JObject Convert(IPresentationResource resource)
        {
            return JObject.FromObject(resource);
        }
    }
}
