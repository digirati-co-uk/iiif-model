using System.Collections.Generic;

namespace Digirati.IIIF3.Model.JSONLD
{
    public abstract class JSONLDBase
    {
        /// <summary>
        /// Only support external contexts for now; allow more than one
        /// </summary>
        public virtual List<string> Context { get; set; }
        public string Id { get; set; }
        public virtual string Type { get; set; }
    }
}
