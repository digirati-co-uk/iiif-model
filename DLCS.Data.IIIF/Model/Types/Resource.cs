using Digirati.IIIF.Model.JsonLD;
using Digirati.IIIF.Serialisation;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    [JsonConverter(typeof(ResourceSerialiser))]
    public class Resource : JSONLDBase
    {
        [JsonProperty(Order = 11, PropertyName = "label")]
        public MetaDataValue Label { get; set; }

        //[JsonProperty(Order = 10, PropertyName = "format")]
        public string Format { get; set; }
    }
}
