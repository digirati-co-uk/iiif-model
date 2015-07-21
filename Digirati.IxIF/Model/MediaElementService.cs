using Digirati.IIIF.Model.JsonLD;
using Digirati.IIIF.Serialisation;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class MediaElementService : JSONLDBase, IMediaElementService, IHasService
    {
        [JsonProperty(Order = 4, PropertyName = "protocol")]
        public string Protocol
        {
            get { return "http://wellcomelibrary.org/ld/ixif"; }
        }
        
        
        [JsonProperty(Order = 39, PropertyName = "profile")]
        [JsonConverter(typeof(ProfileSerialiser))]
        public dynamic Profile { get; set; }

        // Service or Service[] - not currently an interface
        [JsonProperty(Order = 99, PropertyName = "service")]
        [JsonConverter(typeof(ServiceSerialiser))]
        public dynamic Service { get; set; }
    }
}
