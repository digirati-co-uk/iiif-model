using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Layer : IIIFPresentationBase
    {
        [JsonProperty(Order = 31, PropertyName = "viewingDirection")]
        public string ViewingDirection { get; set; }

        public override string Type
        {
            get { return "sc:Layer"; }
        }
    }
}
