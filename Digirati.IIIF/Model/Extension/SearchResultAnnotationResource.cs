using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Extension
{
    public class SearchResultAnnotationResource : JSONLDBase
    {
        public override string Type
        {
            get { return "dctypes:Text"; }
        }

        // these are not yet in the presentation context
        [JsonProperty(Order = 10, PropertyName = "chars")]
        public string Chars { get; set; }

        [JsonProperty(Order = 21, PropertyName = "before")]
        public string Before { get; set; }

        [JsonProperty(Order = 22, PropertyName = "after")]
        public string After { get; set; }

        [JsonProperty(Order = 30, PropertyName = "resultIndex")]
        public int ResultIndex { get; set; }
    }
}
