using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Sequence : IIIFPresentationBase
    {
        [JsonProperty(Order = 31, PropertyName = "startCanvas")]
        public string StartCanvas { get; set; }

        [JsonProperty(Order = 31, PropertyName = "viewingDirection")]
        public string ViewingDirection { get; set; }

        [JsonProperty(Order = 50, PropertyName = "canvases")]
        public Canvas[] Canvases { get; set; }

        public override string Type
        {
            get { return "sc:Sequence"; }
        }
    }
}
