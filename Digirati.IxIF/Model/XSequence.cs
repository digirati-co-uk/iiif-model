using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class XSequence : IIIFPresentationBase
    {
        [JsonProperty(Order = 50, PropertyName = "canvases")]
        public XCanvas[] Canvases { get; set; }

        public override string Type
        {
            get { return "ixif:XSequence"; }
        }
    }
}
