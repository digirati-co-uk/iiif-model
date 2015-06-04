using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types.ImageApi
{
    public class ImageAnnotation : JSONLDBase
    {
        public override string Type
        {
            get { return "oa:Annotation"; }
        }

        [JsonProperty(Order = 4, PropertyName = "motivation")]
        public string Motivation
        {
            get { return "sc:painting"; }
        }

        [JsonProperty(Order = 10, PropertyName = "resource")]
        public ImageResource Resource { get; set; }

        [JsonProperty(Order = 36, PropertyName = "on")]
        public string On { get; set; }

    }
}
