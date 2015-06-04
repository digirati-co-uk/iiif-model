using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class XAnnotation : JSONLDBase
    {
        public override string Type
        {
            get { return "oa:Annotation"; }
        }

        private string motivation;
        [JsonProperty(Order = 4, PropertyName = "motivation")]
        public string Motivation
        {
            get { return motivation ?? "ixif:rendering"; }
            set { motivation = value; } // e.g., for transcription
        }

        [JsonProperty(Order = 10, PropertyName = "resource")]
        public XResource Resource { get; set; }

        [JsonProperty(Order = 36, PropertyName = "on")]
        public string On { get; set; }
    }
}
