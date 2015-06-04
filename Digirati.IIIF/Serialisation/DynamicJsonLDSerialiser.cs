using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Digirati.IIIF.Serialisation
{
    public abstract class DynamicJsonLdSerialiser : JsonConverter
    {
        /// <summary>
        /// We do not need anything special when writing JSON
        /// </summary>
        public override bool CanWrite
        {
            get { return false; }
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }


        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken jToken = JToken.Load(reader);

            var jArray = jToken as JArray;
            if (jArray != null)
            {
                return jArray.Select(ConvertJToken).ToArray();
            }
            return ConvertJToken(jToken);
        }

        public abstract object ConvertJToken(JToken jToken);

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
