using Digirati.IIIF.Model.Types;
using Newtonsoft.Json.Linq;

namespace Digirati.IIIF.Serialisation
{
    public class ResourceSerialiser : DynamicJsonLdSerialiser
    {
        public override object ConvertJToken(JToken jToken)
        {
            return jToken.ToObject<Resource>();
        }
    }
}
