using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class TranscriptAnnotation : JSONLDBase, IAnnotation
    {
        public override string Type
        {
            get { return "oa:Annotation"; }
        }

        [JsonProperty(Order = 4, PropertyName = "motivation")]
        public string Motivation
        {
            get { return "oad:transcribing"; }
        }

        [JsonProperty(Order = 10, PropertyName = "resource")]
        public ElementBase Resource { get; set; }

        [JsonProperty(Order = 36, PropertyName = "on")]
        public string On { get; set; }

    }

}
