using System.Linq;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class MediaSequence : IIIFPresentationBase
    {
        [JsonProperty(Order = 50, PropertyName = "elements")]
        public ElementBase[] Elements { get; set; }

        [JsonProperty(Order = 49, PropertyName = "elementType")]
        public string ElementType
        {
            get
            {
                if (Elements != null && Elements.Any())
                {
                    return Elements[0].Type;
                }
                return null;
            }
        }

        public override string Type
        {
            get { return "ixif:mediaSequence"; }
        }
    }
}
