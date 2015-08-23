using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class GenericService : JSONLDBase, IService
    {
        [JsonProperty(Order = 10, PropertyName = "profile")]
        public virtual dynamic Profile { get; set; }

        [JsonProperty(Order = 11, PropertyName = "label")]
        public MetaDataValue Label { get; set; }

        [JsonProperty(Order = 12, PropertyName = "description")]
        public MetaDataValue Description { get; set; }

        [JsonProperty(Order = 26, PropertyName = "service")]
        public dynamic Service { get; set; } // object or array of objects
    }
}
