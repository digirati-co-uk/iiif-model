using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Service : JSONLDBase, IService
    {
        [JsonProperty(Order = 10, PropertyName = "profile")]
        public dynamic Profile { get; set; }

        [JsonProperty(Order = 11, PropertyName = "label")]
        public MetaDataValue Label { get; set; }
    }
}
