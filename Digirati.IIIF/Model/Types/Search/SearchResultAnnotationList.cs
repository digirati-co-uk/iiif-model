using Digirati.IIIF.Model.Types;
using Digirati.IIIF.Model.Types.Search;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Extension
{
    public class SearchResultAnnotationList : AnnotationList
    {
        public override dynamic Context
        {
            get { return "http://iiif.io/api/search/0/context.json"; }
        }

        [JsonProperty(Order = 10, PropertyName = "within")]
        public SearchResultsLayer Within { get; set; }

        [JsonProperty(Order = 12, PropertyName = "prev")]
        public string Prev { get; set; }

        [JsonProperty(Order = 13, PropertyName = "next")]
        public string Next { get; set; }

        [JsonProperty(Order = 14, PropertyName = "first")]
        public string First { get; set; }

        [JsonProperty(Order = 15, PropertyName = "last")]
        public string Last { get; set; }

        [JsonProperty(Order = 16, PropertyName = "startIndex")]
        public int startIndex { get; set; }

        [JsonProperty(Order = 30, PropertyName = "hits")]
        public Hit[] Hits { get; set; }
    }
}
