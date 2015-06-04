using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class AnnotationListReference : JSONLDBase, IAnnotationListReference
    {
        public override string Type
        {
            get { return "sc:AnnotationList"; }
        }

        [JsonProperty(Order = 40, PropertyName = "label")]
        public MetaDataValue Label { get; set; }
    }
}
