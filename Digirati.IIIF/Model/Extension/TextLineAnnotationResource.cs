using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Extension
{
    public class TextLineAnnotationResource : JSONLDBase
    {
        public override string Type
        {
            get { return "cnt:ContentAsText"; }
        }

        [JsonProperty(Order = 10, PropertyName = "format")]
        public string Format
        {
            get { return "text/plain"; }
        }

        // these are not yet in the presentation context
        [JsonProperty(Order = 20, PropertyName = "chars")]
        public string Chars { get; set; }
    }
}
