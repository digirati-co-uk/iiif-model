using Digirati.IIIF.Model.Types;
using Newtonsoft.Json.Linq;

namespace Digirati.IIIF.Serialisation
{
    public class ServiceSerialiser : DynamicJsonLdSerialiser
    {
        public override object ConvertJToken(JToken jToken)
        {
            return jToken.ToObject<Service>();
        }
    }
}
