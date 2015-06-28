using Newtonsoft.Json;

namespace Digirati.IIIF.Model.JsonLD
{
    public abstract class JSONLDBase : IJSONLDBase
    {
        [JsonProperty(Order = 1, PropertyName = "@context")]
        public virtual dynamic Context { get; set; }

        [JsonProperty(Order = 2, PropertyName = "@id")]
        public string Id { get; set; }

        [JsonProperty(Order = 3, PropertyName = "@type")]
        public virtual string Type { get; set; }
    }
}
