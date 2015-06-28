using Newtonsoft.Json;

namespace Digirati.IIIF.Model.JsonLD
{
    public interface IJSONLDBase
    {
        [JsonProperty(Order = 1, PropertyName = "@context")]
        dynamic Context { get; set; } // can have more than one

        [JsonProperty(Order = 2, PropertyName = "@id")]
        string Id { get; set; }

        [JsonProperty(Order = 3, PropertyName = "@type")]
        string Type { get; set; }
    }
}