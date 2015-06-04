using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class AnnotationList : JSONLDBase
    {
        public override string Type
        {
            get { return "sc:AnnotationList"; }
        }

        [JsonProperty(Order = 20, PropertyName = "resources")]
        public IAnnotation[] Resources { get; set; }
    }
}
