using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Annotation : JSONLDBase, IAnnotation
    {
        [JsonProperty(Order = 10, PropertyName = "motivation")]
        public virtual string Motivation { get; set; }

        public override string Type
        {
            get { return "oa:Annotation"; }
        }

        [JsonProperty(Order = 40, PropertyName = "resource")]
        public JSONLDBase Resource { get; set; }

        [JsonProperty(Order = 50, PropertyName = "on")]
        public string On { get; set; }
    }
}
