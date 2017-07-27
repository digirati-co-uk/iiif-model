using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Digirati.IIIF3
{
    /// <summary>
    /// Not quite a serialiser; bridges the gap from the IIIF model, to a particular
    /// JSON representation in IIIF2 or 3, but doesn't produce stringified JSON
    /// </summary>
    public interface IPresentationJsonConverter
    {
        JObject Convert(IPresentationResource resource);
    }
}
