using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class XManifest : IIIFPresentationBase
    {
        public override string Context
        {
            get { return "http://wellcomelibrary.org/iiif/ixif/0/context.json"; }
        }

        [JsonProperty(Order = 40, PropertyName = "xsequences")]
        public XSequence[] Sequences { get; set; }

        public override string Type
        {
            get { return "ixif:XManifest"; }
        }
    }
}
