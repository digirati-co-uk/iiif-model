using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types.Search
{
    public class TextQuoteSelector : JSONLDBase
    {
        public override string Type
        {
            get { return "oa:TextQuoteSelector"; }
        }

        [JsonProperty(Order = 51, PropertyName = "exact")]
        public string Exact { get; set; }

        [JsonProperty(Order = 52, PropertyName = "prefix")]
        public string Prefix { get; set; }

        [JsonProperty(Order = 53, PropertyName = "suffix")]
        public string Suffix { get; set; }
    }
}
