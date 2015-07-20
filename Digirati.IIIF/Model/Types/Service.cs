﻿using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Service : JSONLDBase, IService
    {
        [JsonProperty(Order = 10, PropertyName = "profile")]
        public virtual dynamic Profile { get; set; }

        [JsonProperty(Order = 11, PropertyName = "label")]
        public MetaDataValue Label { get; set; }

        [JsonProperty(Order = 12, PropertyName = "description")]
        public MetaDataValue Description { get; set; }
    }
}
