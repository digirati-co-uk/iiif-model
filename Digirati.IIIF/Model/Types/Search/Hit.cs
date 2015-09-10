using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types.Search
{
    public class Hit : JSONLDBase
    {
        public override string Type
        {
            get { return "search:Hit"; }
        }

        [JsonProperty(Order = 40, PropertyName = "annotations")]
        public string[] Annotations { get; set; }


        [JsonProperty(Order = 50, PropertyName = "match")]
        public string Match { get; set; }

        [JsonProperty(Order = 51, PropertyName = "before")]
        public string Before { get; set; }

        [JsonProperty(Order = 52, PropertyName = "after")]
        public string After { get; set; }

        // Not used for Wellcome
        [JsonProperty(Order = 60, PropertyName = "selectors")]
        public TextQuoteSelector[] Selectors { get; set; }
    }
}
