using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types.ImageApi
{
    public class Size
    {
        [JsonProperty(Order = 35, PropertyName = "width")]
        public string Width { get; set; }

        [JsonProperty(Order = 36, PropertyName = "height")]
        public string Height { get; set; }
    }
}
