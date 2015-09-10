using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types.Search
{
    public class Term : JSONLDBase
    {
        [JsonProperty(Order = 11, PropertyName = "match")]
        public string Match { get; set; }

        // Hide for now, Wellcome don't know this
        //[JsonProperty(Order = 12, PropertyName = "total")]
        //public int Total { get; set; }

        [JsonProperty(Order = 13, PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(Order = 14, PropertyName = "search")]
        public string Search { get; set; }
    }
}
