using Digirati.IIIF.Model.JsonLD;
using Digirati.IIIF.Serialisation;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types.ImageApi
{
    /// <summary>
    /// A reduced image service that you might typically use in a manifest
    /// </summary>
    public class SimpleImageService : JSONLDBase, IImageService
    {
        public override dynamic Context
        {
            get { return "http://iiif.io/api/image/2/context.json"; }
        }

        [JsonProperty(Order = 39, PropertyName = "profile")]
        public dynamic Profile { get; set; }

        [JsonProperty(Order = 40, PropertyName = "service")]
        [JsonConverter(typeof(ServiceSerialiser))]
        public dynamic Service { get; set; } // object or array of objects
    }
}
