using Digirati.IIIF.Model.Types;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class SequenceWithCompatibilityHint : Sequence
    {
        [JsonProperty(Order = 12, PropertyName = "compatibilityHint")]
        public string CompatibilityHint { get; set; }
    }
}
