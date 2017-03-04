using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Extension
{
    public class IllustrationAnnotationResource : JSONLDBase
    {
        [JsonProperty(Order = 10, PropertyName = "label")]
        public string Label { get; set; }
    }
}
