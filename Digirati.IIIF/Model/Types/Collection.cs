using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Collection : IIIFPresentationBase
    {
        [JsonProperty(Order = 100, PropertyName = "collections")]
        public Collection[] Collections { get; set; }

        [JsonProperty(Order = 101, PropertyName = "manifests")]
        public Manifest[] Manifests { get; set; }

        public override string Type
        {
            get { return "sc:Collection"; }
        }
    }
}
