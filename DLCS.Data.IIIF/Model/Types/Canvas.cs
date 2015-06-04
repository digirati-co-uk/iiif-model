using Digirati.IIIF.Model.Types.ImageApi;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types
{
    public class Canvas : IIIFPresentationBase
    {
        [JsonProperty(Order = 35, PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(Order = 36, PropertyName = "width")]
        public int Width { get; set; }

        // Link to Image resources
        [JsonProperty(Order = 60, PropertyName = "images")]
        public ImageAnnotation[] Images { get; set; }

        //// Link to AnnotationList
        //[JsonProperty(Order = 61, PropertyName = "otherContent")]
        //public Resource[] OtherContent { get; set; }

        public override string Type
        {
            get { return "sc:Canvas"; }
        }
    }
}
