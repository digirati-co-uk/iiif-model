using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public abstract class XCanvas : IIIFPresentationBase
    {
        // Link to media resources
        [JsonProperty(Order = 60, PropertyName = "media")]
        public XAnnotation[] Media { get; set; }
    }
}
