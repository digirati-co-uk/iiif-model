using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types.ImageApi
{
    public class TileSource
    {
        [JsonProperty(Order = 1, PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(Order = 2, PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(Order = 3, PropertyName = "scaleFactors")]
        public int[] ScaleFactors { get; set; }
    }
}
