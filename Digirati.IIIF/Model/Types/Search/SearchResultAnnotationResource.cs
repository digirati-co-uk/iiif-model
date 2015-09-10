using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Extension
{
    public class SearchResultAnnotationResource : JSONLDBase
    {
        public override string Type
        {
            get { return "cnt:ContentAsText"; }
        }

        // these are not yet in the presentation context
        [JsonProperty(Order = 10, PropertyName = "chars")]
        public string Chars { get; set; }
    }
}
