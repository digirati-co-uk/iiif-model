using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Manifest : IIIFPresentationBase
    {
        [JsonProperty(Order = 31, PropertyName = "viewingDirection")]
        public string ViewingDirection { get; set; }

        [JsonProperty(Order = 40, PropertyName = "sequences")]
        public Sequence[] Sequences { get; set; }
        
        [JsonProperty(Order = 50, PropertyName = "structures")]
        public Range[] Structures { get; set; }


        public override string Type
        {
            get { return "sc:Manifest"; }
        }
    }
}
