using Digirati.IIIF.Model.Types;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    /// <summary>
    /// This is still a IIIF manifest. It has one extra property, mediaSequences.
    /// In order for that property to be used, you must add an additional IxIF context when
    /// you build a manifest of this type, otherwise mediaSequences is undefined.
    /// </summary>
    public class ManifestWithMediaSequences : Manifest
    {
        [JsonProperty(Order = 39, PropertyName = "mediaSequences")]
        public MediaSequence[] MediaSequences { get; set; }
    }
}
