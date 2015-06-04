using Digirati.IIIF.Model.Types.ImageApi;
using Newtonsoft.Json.Linq;

namespace Digirati.IIIF.Serialisation
{
    public class ProfileSerialiser : DynamicJsonLdSerialiser
    {
        public override object ConvertJToken(JToken jToken)
        {
            // we need to decide what kind of profile this is
            if (jToken is JValue)
            {
                // it's just a string - 
                return jToken.ToString();
            }
            // for now, this is the only other IProfile implementation
            return jToken.ToObject<ImageServiceProfile>();
        }
    }
}
