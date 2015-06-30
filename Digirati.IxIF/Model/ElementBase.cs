using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    /// <summary>
    /// Marker interface for IxIF element types
    /// </summary>
    public class ElementBase : IIIFPresentationBase
    {
    //    [JsonProperty(Order = 60, PropertyName = "transcriptions")]
    //    public TranscriptAnnotation[] Transcriptions { get; set; }

        // this already exists as sc:hasAnnotations
        [JsonProperty(Order = 60, PropertyName = "resources")]
        public IAnnotation[] Resources { get; set; }
    }
}
