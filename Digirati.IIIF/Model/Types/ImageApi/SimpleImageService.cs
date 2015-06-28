using Digirati.IIIF.Model.JsonLD;
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
    }
}
