using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Range : IIIFPresentationBase
    {
        [JsonProperty(Order = 31, PropertyName = "viewingDirection")]
        public string ViewingDirection { get; set; }

        [JsonProperty(Order = 31, PropertyName = "startCanvas")]
        public string StartCanvas { get; set; }
        
        // URIs of ranges
        [JsonProperty(Order = 41, PropertyName = "ranges")]
        public string[] Ranges { get; set; }
        
        // URIs of canvases
        [JsonProperty(Order = 42, PropertyName = "canvases")]
        public string[] Canvases { get; set; }

        public override string Type
        {
            get { return "sc:Range"; }
        }
    }
}
