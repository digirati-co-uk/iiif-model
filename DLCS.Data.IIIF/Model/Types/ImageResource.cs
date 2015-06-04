using Digirati.IIIF.Model.JsonLD;
using Digirati.IIIF.Model.Types.ImageApi;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class ImageResource : JSONLDBase
    {
        [JsonProperty(Order = 10, PropertyName = "format")]
        public string Format { get; set; }

        [JsonProperty(Order = 35, PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(Order = 36, PropertyName = "width")]
        public int Width { get; set; }

        public override string Type
        {
            get { return "dcTypes:Image"; }
        }

        [JsonProperty(Order = 99, PropertyName = "service")]
        public IImageService Service { get; set; }
    }
}
