using Digirati.IIIF.Serialisation;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Types.ImageApi
{
    [JsonConverter(typeof(ToStringJsonConverter))]
    public class UriProfile : IProfile
    {
        public string Profile { get; set; }

        public override string ToString()
        {
            return Profile;
        }
    }
}
