using Newtonsoft.Json;

namespace Digirati.IIIF.Model.JsonLD
{
    public interface IJSONLDBase
    {
        [JsonProperty(Order = 1, PropertyName = "@context")]
        string Context { get; set; }

        [JsonProperty(Order = 2, PropertyName = "@id")]
        string Id { get; set; }

        [JsonProperty(Order = 3, PropertyName = "@type")]
        string Type { get; set; }
    }
}