using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class XResource : JSONLDBase
    {
        // @id provides the URI

        // format provides the encoding
        [JsonProperty(Order = 10, PropertyName = "format")]
        public string Format { get; set; }

        public override string Type
        {
            get { return "ixif:XResource"; }
        }
    }
}
