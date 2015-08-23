using Digirati.IIIF.Model.Types;
using Newtonsoft.Json.Linq;

namespace Digirati.IIIF.Serialisation
{
    public class ServiceSerialiser : DynamicJsonLdSerialiser
    {
        // TODO: this can currently only read a GenericService
        public override object ConvertJToken(JToken jToken)
        {
            return jToken.ToObject<GenericService>();
        }
    }
}
