using Digirati.IIIF.Model.JsonLD;
using Digirati.IIIF.Model.Types.ImageApi;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    /// <summary>
    /// A reduced ... service that you might typically use in a manifest
    /// </summary>
    public class SimpleMediaElementService : JSONLDBase, IMediaElementService
    {
        [JsonProperty(Order = 39, PropertyName = "profile")]
        public dynamic Profile { get; set; }

        public dynamic Service { get; set; }
    }
}
