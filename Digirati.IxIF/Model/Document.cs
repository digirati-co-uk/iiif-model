using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class Document : ElementBase
    {
        public override string Type
        {
            get { return "foaf:Document"; }
        }

        [JsonProperty(Order = 5, PropertyName = "format")]
        public string Format { get; set; }
    }
}
